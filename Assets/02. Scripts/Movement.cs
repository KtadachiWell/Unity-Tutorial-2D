using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this.transform.position = transform.position = this.transform.position + Vector3.back;

        moveSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // moveSpeed = Time.deltaTime;
        // this.transform.position = transform.position = this.transform.position + Vector3.forward * moveSpeed;
        // this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // 위에꺼에서 간소화해서 델타타임 보정 들어간 버전
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
