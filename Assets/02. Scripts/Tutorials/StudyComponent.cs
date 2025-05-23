using UnityEngine;

public class StudyComponent : MonoBehaviour
    // 접근 제한자 , 클래스 명 : (상속) 유니티의 유용한 기능들이 들어있는 곳 ▲
{
    public GameObject obj; // 큐브 게임 오브젝트를 가져오고 싶다.
    // 이거만 만들어놔도 유니티 내에서 직접 할당 가능.

    public string changeName;
    // 접근제한자, 타입, 변수명

    private void Start() // void는 결과(반환타입)이 없는 함수
    {
        // obj = GameObject.Find("Main Camera"); // 이렇게하면 메인 카메라를 obj에 넣어버림; ㄹㅈㄷ
        // obj.name = changeName;
        // obj.transform.name 으로 해도 수정은 되는데 걍 짧은게 나은듯.

        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log($"<color=#ff0000>이름 : {obj.name}"); // 게임오브젝트의 이름
        Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

        // MeshFilter 컴포넌트에 접근해서 mesh를 log로 출력하는 기능
        Debug.Log($"Mesh 데이터: {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer 컴포넌트에 접근해서 material을 log로 출력하는 기능
        Debug.Log($"Material 데이터:{obj.GetComponent<MeshRenderer>().material}");
    }
}
