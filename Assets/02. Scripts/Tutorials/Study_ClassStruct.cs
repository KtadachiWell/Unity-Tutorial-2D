using UnityEngine;

// Ŭ������ ����ü�� �޸��� ���̸� Ȯ���ϱ� ���� ������Ʈ
public class Study_Class
{
    public int number;

    public Study_Class(int number) //�ؿ� ����ü �����ؼ�, MonoBehaviour�� ������ �ʴ� Ŭ�������� �ٷ� �����ڸ� ���� �� �ִ�.
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}

public class Study_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Ŭ���� ---------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1: {c1.number} / c2 : {c2.number}"); // 10, 10�� ����.

        c1.number = 100;
        // c1�� number�� �ҷ����� ���� �������ϻ�, ���빰�� ��� number�� �����ϴ� ��Ÿ����.
        // c2�� c1���Լ� ���� �޾ƿ����� �ص�, c2�� c1�� ���빰�� ��� c1�� ���� ����Ű�� ���� number�� ���� ����Ű�� ��.
        // �׷��� c2�� c1�� ���� number�� ����Ű�� �Ǹ鼭, number�� ���� �ٲ�� c1�� c2���� ���� number�� ����Ű�Ƿ� �Ʒ��� ���� ����� ������ �Ǵ� ��.
        Debug.Log($"c1: {c1.number} / c2 : {c2.number}"); // 100, 100�� ������ ��



        Debug.Log("����ü ---------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1: {s1.number} / s2 : {s2.number}"); // 10, 10�� ����.

        s1.number = 100;
        // ����ü�� ��ü������ ���� ������ ������, �ٸ� �����Ϳ��� �����ؼ� ���� �������(����Ű��)�� �ƴ�.
        // �׷��� s1�� number�� 100���� �ص� s2�� number�� ó�� �����ص� ��ó�� 10�� �����Ǵ� ��.
        Debug.Log($"s1: {s1.number} / s2 : {s2.number}"); // 100, 10�� �����ԉ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
