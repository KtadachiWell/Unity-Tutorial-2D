using UnityEngine;

public class StudyArray : MonoBehaviour
{

    int[] arrayNumber = new int[5] {1,2,3,4,5};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� ������° �� : {arrayNumber[5]}");
    }
}
