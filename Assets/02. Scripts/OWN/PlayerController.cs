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

        // Input
        private float horizontalInput;
        private bool jumpInput;

        // Ground Check
        private bool isGrounded;

        // Movement
        private bool facingRight = true;

        private void Start()
        {

        }

        private void Update()
        {
            HandleInput();
        }

        private void FixedUpdate()
        {
            
        }

        void HandleInput()
        {
            // WASD 및 방향키 이동 (A D, 방향키)
            horizontalInput = 0f;

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                horizontalInput -= 1f;
            }else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) { horizontalInput += 1f; }

            // 점프
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                
            }
        }
    }

}
