using UnityEngine;

public class RouletteController : MonoBehaviour
{

    public float rotSpeed;

    public bool isStop; // 불리언 값은 기본 false

    private void Start()
    {
        rotSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime); // Z축 기준으로 회전
        // Vector3 축 방향 헷갈리면 씬에서 회전(E) 눌러서 보면 이해하기 쉬움.
        // transform.Rotate(0f,0f,rotSpeed); 로 해도 상관없음. 델타타임은 몰?루

        // 마우스 좌클릭하면 회전력이 올라가는 기능
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed += 100f;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
            // rotSpeed = 0f; // 바로 멈춤
        }
        else if (isStop == true)
        {
            rotSpeed *= 0.98f; // 서서히 감속시키는 것 날먹
        }

        if (rotSpeed < 0.01f) {

            isStop = false; // 속도가 거의 멈춤에 가까워지면 더이상 안돌게 먼저 불리언 값 거짓으로 변경, 그냥 두면 무한으로 연산하면서 정지에 가까운 움직이는 상태를 유지하니까.
            rotSpeed = 0f; // 그 이후에 0으로 초기화해서 완전 정지 상태로
        
        }


    }
}
