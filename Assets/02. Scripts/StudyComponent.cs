using UnityEngine;

public class StudyComponent : MonoBehaviour
    // ���� ������ , Ŭ���� �� : (���) ����Ƽ�� ������ ��ɵ��� ����ִ� �� ��
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �������� �ʹ�.
    // �̰Ÿ� �������� ����Ƽ ������ ���� �Ҵ� ����.

    public string changeName;
    // ����������, Ÿ��, ������

    private void Start() // void�� ���(��ȯŸ��)�� ���� �Լ�
    {
        // obj = GameObject.Find("Main Camera"); // �̷����ϸ� ���� ī�޶� obj�� �־����; ������
        // obj.name = changeName;
        // obj.transform.name ���� �ص� ������ �Ǵµ� �� ª���� ������.

        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log($"<color=#ff0000>�̸� : {obj.name}"); // ���ӿ�����Ʈ�� �̸�
        Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        // MeshFilter ������Ʈ�� �����ؼ� mesh�� log�� ����ϴ� ���
        Debug.Log($"Mesh ������: {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer ������Ʈ�� �����ؼ� material�� log�� ����ϴ� ���
        Debug.Log($"Material ������:{obj.GetComponent<MeshRenderer>().material}");
    }
}
