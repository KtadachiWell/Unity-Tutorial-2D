using System.Collections.ObjectModel;
using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    public string[] persons = new string[5] {"철수", "영희", "동수", "마이클", "존"};

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
         } 위에 포이치를 포로 변환하면 이런 느낌임 */

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
                Debug.Log($"인원 중에 {name}가 존재합니다.");
            }
        } if (!isFind) Debug.Log($"{name}을 찾지 못했습니다.");
    }

}
