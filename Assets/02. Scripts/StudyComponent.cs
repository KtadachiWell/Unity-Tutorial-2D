using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임 오브젝트를 가져오고 싶다.
    // 이거만 만들어놔도 유니티 내에서 직접 할당 가능.

    public string changeName;

    private void Start()
    {
        obj = GameObject.Find("Main Camera"); // 이렇게하면 메인 카메라를 obj에 넣어버림; ㄹㅈㄷ
        obj.name = changeName;
        // obj.transform.name 으로 해도 수정은 되는데 걍 짧은게 나은듯.
    }
}
