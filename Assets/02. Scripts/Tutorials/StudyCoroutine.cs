using UnityEngine;
using System.Collections;

public class StudyCoroutine : MonoBehaviour
{
    private void Start()
    {
        // StartCoroutine("RoutineA"); �κ�ũ�ϵ� �̷��� �ص� �ڷ�ƾ�� ���������
        StartCoroutine(RoutineA()); // �̷��� �ϴ� �� �� ���ٰ� ��.
    }

    void MethodA()
    {
        // �̰� �Լ��� �ڷ�ƾ�� �ƴ�
        Debug.Log("asdf");
    }

    IEnumerator RoutineA()
    {
        yield return null; // 1�� ������ ���

        Debug.Log("�ڷ�ƾ ����");
    }
}
