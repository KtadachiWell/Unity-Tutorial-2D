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
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;  

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {obj.transform.childCount}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.transform.GetChild(count-1).name}");
    }
}

    // Update is called once per frame
    //void Start()
    //{
    //    CreateAmongUs();
    //    Destroy(destroyObj, 3f); // 3�� �ڿ� ��Ʈ���� ��ɾ ������.
    //}

    //private void OnDestroy() //OnDestroy�� ����Ƽ ��ü �Լ���, ���α׷��� ���� ��(������ ��) �۵���.
    //{
    //    Debug.Log("<color=#ff0000>�ı��Ǿ����ϴ�.");
    //}


    //public void CreateAmongUs() // �̸� ����־�� (���� ĳ����) �����ϰ� �̸� �����ϴ� �Լ�
    //{

    //    GameObject obj = Instantiate(prefab, pos, rot); // GameObject�� �����ϴ� ���
    //    // ������ ������, ��ġ, ȸ�� ��

    //    obj.name = "���� ĳ����";

    //}
//}
