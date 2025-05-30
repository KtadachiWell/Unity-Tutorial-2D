using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{

    Rigidbody2D characterRb;
    public float moveSpeed;
    public float jumpPower = 10f;
    public float dashPower = 8f;
    float h;
    bool isGround;
    bool isJumping;
    public int dashCount = 0;
    bool canExtraJump;
    int mouseOnHit = 0;
    // public GameObject[] animObjects;
    public SpriteRenderer[] renderers;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>();    // �ڽ� ������Ʈ �ȿ��� ��������Ʈ �������� ���� �ֵ��� ������ ������ �������ڴ�
        // ��, �� �ڵ�� ����Ƽ�� �ڵ����� �־��ٰŶ� ���� ���������� ������ �ʿ� ����.
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal"); // Ű �Է� �ޱ� a,d,��,��
        // v = Input.GetAxis("Vertical"); // Ű �Է� �ޱ� w,s,��,��

        CharacterJump();
        CharacterFlipInJump();
        
        
    }

    private void FixedUpdate()
    {
        CharacterMove();
    }

    /// <summary>
    ///  ĳ���� �����ӿ� ���� �̹����� Flip ���°� ���ϴ� �ڵ尡 ����ִ� �Լ� CharacterMove()
    /// </summary>

    void CharacterMove()
    {
        // Ʈ������ �̵�
        // transform.position ~
        // transform.Translate(~)

        if (!isGround)
            return;


        if (h != 0) // ������ ��, �̸鼭 ���鿡 ĳ���Ͱ� ������� ��.
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run
            

            //������ �̵�(������ �ٵ�), but �̰� FixedUpdate�� �־����.
            //�ٵ� �̵��� ��°ġ�� Ű �Էµ� FixedUpdate���� �ع����� ��ǲ ������ ��������� ������.
            characterRb.linearVelocityX = h * moveSpeed;

            if (h > 0)
            {
                renderers[1].flipX = false; // �ø��� �� ������, �� ��������Ʈ���� ���� ��ȯ��.
                renderers[0].flipX = false; // �ٵ� �������� �����̴� ������ �� ������ ���� �������� �̻��ϴϱ� �� �� ���� �ٲ��شٴ� ����.
                renderers[2].flipX = false;
            }
            else if (h < 0)
            {
                renderers[1].flipX = true;
                renderers[0].flipX = true;
                renderers[2].flipX = true;
            }
               
            
        }
        else if (h == 0) // �������� ���� ��.
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
            renderers[2].gameObject.SetActive(false); // Jump
        }
    }

    void CharacterJump()
    {
        if (isJumping == false)
        {
            // if (Input.GetButtonDown("Jump")) // ��Ű�ٿ� �����̽��ٶ� ���� ����
            if (Input.GetButtonDown("Vertical"))
            {
                characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                isJumping = true;
                
            }

        }
        if (canExtraJump == true && isJumping == true && Input.GetButtonDown("Vertical"))
        {
            characterRb.linearVelocityY = 0;
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            canExtraJump = false;
            dashCount = 0;
        }
    }

    void CharacterFlipInJump()
    {
        if (isGround == true)
            return;

        if (isGround == false && h != 0 && isJumping == true)
        {
            if (h > 0)
            {
                renderers[2].flipX = false;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    characterRb.AddForceX(dashPower, ForceMode2D.Impulse);
                    if (dashCount < 2)
                    {
                        dashCount++;
                    }
                    else
                    {
                        canExtraJump = true;
                        dashCount = 0;
                    }
                }
            }
            else if (h < 0)
            {
                renderers[2].flipX = true;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    characterRb.AddForceX(-dashPower, ForceMode2D.Impulse);
                    if (dashCount < 2)
                    {
                        dashCount++;
                    }
                    else
                    {
                        canExtraJump = true;
                        dashCount = 0;
                    }
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            renderers[2].gameObject.SetActive(false); // Jump
            isJumping = false;
            dashCount = 0;
            canExtraJump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
            renderers[2].gameObject.SetActive(true); // Jump
            renderers[1].gameObject.SetActive(false);
            renderers[0].gameObject.SetActive(false);
        }
    }
}


