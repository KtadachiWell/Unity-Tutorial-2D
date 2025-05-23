using UnityEngine;

// 클래스와 구조체의 메모리의 차이를 확인하기 위한 프로젝트
public class Study_Class
{
    public int number;

    public Study_Class(int number) //밑에 구조체 포함해서, MonoBehaviour에 속하지 않는 클래스들은 바로 생성자를 만들 수 있다.
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
        Debug.Log("클래스 ---------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1: {c1.number} / c2 : {c2.number}"); // 10, 10이 나옴.

        c1.number = 100;
        // c1은 number를 불러오기 위한 껍데기일뿐, 내용물은 없어서 number를 참조하는 스타일임.
        // c2는 c1에게서 값을 받아오려고 해도, c2는 c1의 내용물이 없어서 c1이 값을 가리키는 곳인 number를 같이 가리키게 됌.
        // 그래서 c2와 c1은 같은 number를 가리키게 되면서, number의 값이 바뀌면 c1와 c2역시 같은 number를 가리키므로 아래와 같은 결과가 나오게 되는 것.
        Debug.Log($"c1: {c1.number} / c2 : {c2.number}"); // 100, 100이 나오게 됌



        Debug.Log("구조체 ---------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1: {s1.number} / s2 : {s2.number}"); // 10, 10이 나옴.

        s1.number = 100;
        // 구조체는 자체적으로 값을 가지고 있으며, 다른 데이터에서 참조해서 값을 끌어오는(가리키는)게 아님.
        // 그래서 s1의 number를 100으로 해도 s2의 number는 처음 지정해둔 것처럼 10이 유지되는 것.
        Debug.Log($"s1: {s1.number} / s2 : {s2.number}"); // 100, 10이 나오게됌
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
