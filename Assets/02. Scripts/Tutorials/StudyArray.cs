using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class StudyArray : MonoBehaviour
{

    public int[] arrayNumber = new int[5] {1,2,3,4,5};

    public List<int> listNumber = new List<int>();

    public int number3 = 3;

    // �ø��������� �����͸� ����ȭ ��Ų�ٴ� ��ɾ�.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        // listNumber[0] : ù��° ������
        // listNumber[2] : ����° ������
         

        Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� �ټ���° �� : {arrayNumber[4]}");
        Debug.Log($"���� Array�� �ִ� ������ �� : {arrayNumber.Length}"); // ���� �迭 - �Ϸķ� �ִ� ���̶� ����.

        Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}"); // ���� �迭 - �� �̾��� ���� �ƴ϶� ī��Ʈ.

        // arrayNumber[arrayNumber.length-1]; ������ �����Ϳ� �����ϴ� ��
        // listNumber[ListNumber.count-1]; ���� ����
    }
}
