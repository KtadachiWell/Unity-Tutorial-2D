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

        // transform 이동
        // transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate() //고정 프레임으로 실행되지만 느린 단점이 있는 업데이트 함수
    {

        float h = Input.GetAxis("Horizontal");

        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;
    }
}
