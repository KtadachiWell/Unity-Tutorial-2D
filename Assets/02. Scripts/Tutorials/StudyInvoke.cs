using Unity.VisualScripting;
using UnityEngine;

public class StudyInvoke : MonoBehaviour
{

    public int count = 10;

    void Start()
    {
        InvokeRepeating("Bomb", 0f, 1f);
    }

    private void Bomb()
    {
        Debug.Log($"현재 남은 시간 : {count}초");
        count--;

        if (count == 0)
        {
            Debug.Log("폭탄이 터졌습니다.");
            CancelInvoke("Bomb"); // 폭탄이 터졌으니 0초 무한 반복 안되게 Bomb함수 반복되던거 취소 시키기
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Bomb");
            Debug.Log("폭탄이 해제되었습니다.");
        }
    }

    /*public float timer = 5f;

     void Start()
    {
        Invoke("Method1", timer);

        // CancelInvoke("Method1") 이런식으로 캔슬도 시킬 수 있음.
        // InvokeRepeating("Method1", 3f, 1f); 이건 특정 함수를 처음 지연시간과 반복 실행에 필요한 시간을 입력해놓고 쓰는 타이머 함수 같은 역할

    }

    private void Method1()
    {
        Debug.Log("Invoke 메서드 실행");
    } */
}
