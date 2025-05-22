using UnityEngine;
using UnityEngine.UIElements;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;  

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.transform.GetChild(count-1).name}");
    }
}

    // Update is called once per frame
    //void Start()
    //{
    //    CreateAmongUs();
    //    Destroy(destroyObj, 3f); // 3초 뒤에 디스트로이 명령어가 실행됌.
    //}

    //private void OnDestroy() //OnDestroy는 유니티 자체 함수로, 프로그램이 꺼질 때(종료할 때) 작동함.
    //{
    //    Debug.Log("<color=#ff0000>파괴되었습니다.");
    //}


    //public void CreateAmongUs() // 미리 집어넣어둔 (어몽어스 캐릭터) 생성하고 이름 변경하는 함수
    //{

    //    GameObject obj = Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능
    //    // 생성할 데이터, 위치, 회전 순

    //    obj.name = "어몽어스 캐릭터";

    //}
//}
