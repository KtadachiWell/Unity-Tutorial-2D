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
        Debug.Log($"���� ���� �ð� : {count}��");
        count--;

        if (count == 0)
        {
            Debug.Log("��ź�� �������ϴ�.");
            CancelInvoke("Bomb"); // ��ź�� �������� 0�� ���� �ݺ� �ȵǰ� Bomb�Լ� �ݺ��Ǵ��� ��� ��Ű��
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Bomb");
            Debug.Log("��ź�� �����Ǿ����ϴ�.");
        }
    }

    /*public float timer = 5f;

     void Start()
    {
        Invoke("Method1", timer);

        // CancelInvoke("Method1") �̷������� ĵ���� ��ų �� ����.
        // InvokeRepeating("Method1", 3f, 1f); �̰� Ư�� �Լ��� ó�� �����ð��� �ݺ� ���࿡ �ʿ��� �ð��� �Է��س��� ���� Ÿ�̸� �Լ� ���� ����

    }

    private void Method1()
    {
        Debug.Log("Invoke �޼��� ����");
    } */
}
