using System.Collections.ObjectModel;
using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    public string[] persons = new string[5] {"ö��", "����", "����", "����Ŭ", "��"};

    public string findName;
    void Start()
    {
        /* int count = 0;
        foreach (string person in persons)
        {
            count++;
            Debug.Log(person);

            if (count == 3)
            {
                break;
            }
        } */

        /* for (int i = 0; i < persons.Length; i++)
         {
             Debug.Log(persons[i]);
         } ���� ����ġ�� ���� ��ȯ�ϸ� �̷� ������ */

        FindPerson(findName);
    }

    void FindPerson(string name)
    {
        bool isFind = false;
        foreach (var person in persons)
        {
            
            if (person == name)
            {
                isFind = true;
                Debug.Log($"�ο� �߿� {name}�� �����մϴ�.");
            }
        } if (!isFind) Debug.Log($"{name}�� ã�� ���߽��ϴ�.");
    }

}
