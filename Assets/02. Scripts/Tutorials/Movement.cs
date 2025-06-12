using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

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

    //private void Update()
    //{
    //    /// Input System (Old - Legacy)
    //    /// 입력값에 대한 약속된 시스템
    //    /// 이동 -> WASD, 화살표키보드
    //    /// 점프 -> Space
    //    /// 총쏘기 -> 마우스 왼쪽

    //    // 부드럽게 증감하는 값
    //    //float h = Input.GetAxis("Horizontal"); // wasd랑 화살표키 움직임 둘다 작동함
    //    //float v = Input.GetAxis("Vertical"); // 위와 동일

    //    // 딱 떨어지는 값
    //    float h2 = Input.GetAxisRaw("Horizontal");
    //    float v2 = Input.GetAxisRaw("Vertical");

    //    Vector3 dir = new Vector3(h2, 0, v2); // 이렇게하면 대각선으로 이동할 때 1,0,1 값이 들어가서 더 빠르게 이동하게 됌.

    //    Vector3 normalDir = dir.normalized; // 위의 값에서 정규화 과정을 가지게됌. ( 0 ~ 1 )
    //    Debug.Log($"현재 입력 : {normalDir}");

    //    transform.position += normalDir * moveSpeed * Time.deltaTime;

    //    transform.LookAt(transform.position + normalDir);
    //}
//}


