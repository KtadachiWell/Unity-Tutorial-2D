using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �������� �ʹ�.
    // �̰Ÿ� �������� ����Ƽ ������ ���� �Ҵ� ����.

    public string changeName;

    private void Start()
    {
        obj = GameObject.Find("Main Camera"); // �̷����ϸ� ���� ī�޶� obj�� �־����; ������
        obj.name = changeName;
        // obj.transform.name ���� �ص� ������ �Ǵµ� �� ª���� ������.
    }
}
