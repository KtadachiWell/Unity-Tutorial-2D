using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class StudyArray : MonoBehaviour
{

    public int[] arrayNumber = new int[5] {1,2,3,4,5};

    public List<int> listNumber = new List<int>();

    public int number3 = 3;

    // 시리얼라이즈는 데이터를 직렬화 시킨다는 명령어.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        // listNumber[0] : 첫번째 데이터
        // listNumber[2] : 세번째 데이터
         

        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        Debug.Log($"Array의 다섯번째 값 : {arrayNumber[4]}");
        Debug.Log($"현재 Array에 있는 데이터 수 : {arrayNumber.Length}"); // 정적 배열 - 일렬로 있는 값이라서 렝쓰.

        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}"); // 동적 배열 - 쭉 이어진 값이 아니라서 카운트.

        // arrayNumber[arrayNumber.length-1]; 마지막 데이터에 접근하는 법
        // listNumber[ListNumber.count-1]; 위와 동일
    }
}
