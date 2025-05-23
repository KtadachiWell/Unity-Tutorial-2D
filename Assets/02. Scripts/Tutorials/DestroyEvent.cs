using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime); // �ڱ� �ڽ��� ������ ������ ���� �ð� �Ŀ� �ı��ϴ� ���

    }

    private void OnDestroy() // ������Ʈ�� �ı��ɶ��� ������. (����Ƽ ���α׷��� ������ ��� ����)
    {
        Debug.Log($"{this.gameObject.name} �� �ı��Ǿ����ϴ�.");        
    }
}
