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
            // ���� = y�� �������� �̵� X
            // Impulse�� ���������� ���� ���ϴ� �Ű�, Force�� ����ؼ� ���� ���ϴ� ���̶�� ��.
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
