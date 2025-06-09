using UnityEngine;
using System.Collections;

public class StudyCoroutine : MonoBehaviour
{
    private void Start()
    {
        // StartCoroutine("RoutineA"); 인보크하듯 이렇게 해도 코루틴은 실행되지만
        StartCoroutine(RoutineA()); // 이렇게 하는 게 더 좋다고 함.
    }

    void MethodA()
    {
        // 이건 함수고 코루틴이 아님
        Debug.Log("asdf");
    }

    IEnumerator RoutineA()
    {
        yield return null; // 1개 프레임 대기

        Debug.Log("코루틴 실행");
    }
}
