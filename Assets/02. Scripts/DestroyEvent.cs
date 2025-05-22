using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime); // 자기 자신을 정해진 변수의 지연 시간 후에 파괴하는 기능

    }

    private void OnDestroy() // 오브젝트가 파괴될때도 실행됌. (유니티 프로그램이 꺼지는 경우 포함)
    {
        Debug.Log($"{this.gameObject.name} 이 파괴되었습니다.");        
    }
}
