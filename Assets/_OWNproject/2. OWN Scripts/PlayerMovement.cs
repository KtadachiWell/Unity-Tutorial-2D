using Unity.IntegerTime;
using Unity.VisualScripting;
using UnityEngine;

namespace OWNproject.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("컴포넌트")]
        private Rigidbody2D rb;
        private Transform playerTransform;

        [Header("이동 설정")]
        [SerializeField] private float moveSpeed = 7f;
        [SerializeField] private float airMoveMultiplier = 0.5f; // 공중에서 이동시 이동 속도 감소량, 0.5는 50% 감소예요~
        private float moveInput;
        private bool isFacingRight = true;

        [Header("점프 설정")]
        [SerializeField] private float jumpForce = 14f;
        [SerializeField] private Transform groundCheck; // 바닥 체크용 위치
        [SerializeField] private LayerMask groundLayer; // 바닥 레이어
        [SerializeField] private float groundCheckRadius = 0.2f;
        private bool isGrounded;

        [Header("대쉬 설정")]
        [SerializeField] private float dashSpeed = 20f;
        [SerializeField] private float dashTime = 0.2f; // 대쉬 지속시간
        [SerializeField] private float dashCooldown = 1f; // 대쉬 쿨타임
        private bool canDash = true;
        private bool isDashing = false;

        // 대쉬 입력을 위한 변수들
        private float lastLeftPressTime;
        private float lastRightPressTime;
        [SerializeField] private float doubleTapTime = 0.2f; // 더블탭 인식 시간, 연속 키 입력 인식 시간

        // 컴포넌트 가져오기

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            playerTransform = transform;
        }

        private void Update()
        {
            // 대쉬 중이 아닐 때만 입력을 받습니다.
            if (isDashing)
            {
                return;
            }

            // 1. 이동 입력
            moveInput = Input.GetAxisRaw("Horizontal");

            // 2. 점프 입력
            // 바닥에 있을 때만 점프 가능
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

            if (isGrounded && (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                // y축 속도를 0으로 초기화 후 점프해야 일정한 점프 높이를 보장
                rb.linearVelocity = new Vector2(rb.linearVelocityX, 0f);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }

            HandleDashInput();
            FlipCharacter();
        }

        private void FixedUpdate()
        {
            if (isDashing) return;

            // 지면에 닿아있을 때만 수평 이동 가능하게
            if (isGrounded)
            {
                // 땅에 있을 때는 100% 속도로 이동
                rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocityY);
            } else // 땅에 없을 때 ( 공중일 때 )
            {
                rb.linearVelocity = new Vector2(moveInput * moveSpeed * airMoveMultiplier, rb.linearVelocityY);
            }
        }

        // 코루틴은 IEnumerator에게 시간표를 반환하기로 약속하는 개념으로, 언제 쉬고 언제 다시 시작할지가 적힌다.
        // 그래서 만약 해당 함수를 만들기만 하고, 따로 {}에 내용을 추가하지 않는다면 시간표 준다더니 왜 안주는 거야? 라고 하면서 오류가 나는 것이라고 함.
        // yield return이라고 하는 키워드로 이 시간표를 완성해야하고, 그것이 코루틴의 특별한 점이라고 한다.
        private System.Collections.IEnumerator Dash(float direction) 
        {
            canDash = false;
            isDashing = true;

            float originalGravity = rb.gravityScale;
            rb.gravityScale = 0f;

            rb.linearVelocity = new Vector2(direction * dashSpeed, 0f);

            // dashTime만큼 기다리는 시간표를 만들어서 반환
            yield return new WaitForSeconds(dashTime);

            rb.gravityScale = originalGravity;
            isDashing = false;

            // dashCooldown만큼 기다리는 시간표를 만들어서 반환
            yield return new WaitForSeconds(dashCooldown);

            canDash = true;

            // 간단히 말해, IEnumerator를 반환 타입으로 쓰는 코루틴 함수는 함수 내부에서 yield return 구문이 적어도 1회 이상은 반드시 포함되어야만 한다.
        }

        private void HandleDashInput()
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (Time.time - lastLeftPressTime < doubleTapTime) { if (canDash) StartCoroutine(Dash(-1)); }
                lastLeftPressTime = Time.time;
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (Time.time - lastRightPressTime < doubleTapTime) { if (canDash) StartCoroutine(Dash(1)); }
                lastRightPressTime = Time.time;
            }
        }

        private void FlipCharacter()
        {
            if ((isFacingRight && moveInput < 0f) || (!isFacingRight && moveInput > 0f))
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = playerTransform.localScale;
                localScale.x *= -1f;
                playerTransform.localScale = localScale;
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (groundCheck == null) return;
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }

}
