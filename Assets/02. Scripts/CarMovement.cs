using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public float moveSpeed = 3f;

    public Rigidbody2D carRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float h = Input.GetAxis("Horizontal");

        // transform �̵�
        // transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate() //���� ���������� ��������� ���� ������ �ִ� ������Ʈ �Լ�
    {

        float h = Input.GetAxis("Horizontal");

        // Rigidbody�� �ӵ��� Ȱ���� �̵�
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;
    }
}
