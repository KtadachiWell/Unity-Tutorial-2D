using TMPro;
using UnityEngine;

public class CatController : MonoBehaviour
{

    private Rigidbody2D catRb;
    public float jumpPower = 8f;
    private bool jumpLimit = false;
    public int jumpMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        catRb = GetComponent<Rigidbody2D>();
        jumpMax = 0;
    }

    void CatJump()
    {
        if (jumpLimit == false)
        {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // 점프 = y축 방향으로 이동 X
            // Impulse는 순간적으로 힘을 가하는 거고, Force는 계속해서 힘을 가하는 것이라고 함.
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                jumpMax++;
        }
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpMax = 0;
            jumpLimit = false;
            jumpPower = 8.0f;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpMax >= 2)
        {
            jumpLimit = true;
            jumpPower = 8f;
        } else if (jumpMax == 1)
        {
            jumpPower = 5f;
        }
            CatJump();

    }
}
