using UnityEngine;

namespace OWNproject
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 5f;
        public float jumpForce = 12f;

        [Header("Physics")]
        public float fallMultiplier = 2.5f;
        public float lowJumpMultiplier = 2f;

        // Components
        private Rigidbody2D rb;
        private Animator animator;
        public SpriteRenderer[] spriteRenderer;

        // Input
        private float horizontalInput;
        private bool jumpInput;

        // Ground Check
        private bool isGrounded;

        // Movement
        private bool facingRight = true;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            spriteRenderer = GetComponentsInChildren<SpriteRenderer>();
        }

        private void Update()
        {
            HandleInput();
        }

        private void FixedUpdate()
        {
            HandleMovement();
        }

        void HandleInput()
        {
            // WASD 및 방향키 이동 (A D, 방향키)
            horizontalInput = 0f;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                horizontalInput -= 1f;
            }else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { horizontalInput += 1f; }

            // 점프
            if (Input.GetKey(KeyCode.Space) && isGrounded)
            {
                
            }
        }

        void HandleMovement()
        {
            rb.linearVelocityX = horizontalInput * moveSpeed;
        }
    }

}
