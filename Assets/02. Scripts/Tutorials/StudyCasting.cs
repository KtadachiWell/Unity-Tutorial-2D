using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class StudyCasting : MonoBehaviour // 자료형(데이터 타입을 변경하는 것)을 형변환(캐스팅)이라고 한다.
{
    int number1 = 1;
    float number2 = 10f;
    float number3 = 2.75f;

    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();
    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        Orc o = new Orc();
        Goblin g = new Goblin();

        // 암시적 형변환 - 명시적 형변환에 비해 개발 효율이 올라감
        Monster m1 = o;
        Monster m2 = g;

        // 명시적 형변환 - 암시적 형변환에 비해 가독성이 높음
        Monster m3 = (Monster)o;
        Monster m4 = (Monster)g;

        monsters.Add(o);
        monsters.Add(g);
        // 이렇게 넣어버리면, 몬스터 타입 일괄로 잡아서 함수 사용하기 수월해짐
        // ex: monster.AllAttack();

        //int numb1 = 123;

        //// string str1 = numb1; // 형변환 불가
        //// string str2 = (string)numb1; // 형변환 불가
        //string str3 = numb1.ToString(); // 이거만 형변환 됌. -> "123" 문자열로 바뀜

        //int numb2 = 0;
        //int numb3 = 1;
        //int numb4 = 2;
        //int numb5 = 100;
        //string strin1 = "안녕하세요.";
        //string strin2 = "true";
        //string strin3 = "false";
        //float flo = 0.1254f;
        //float flo2 = 0.0f;

        //// int형을 불리언 타입으로 형 변환 할 경우, 0을 제외한 모든 값은 true고 0은 false처리 됌.
        //// float 타입도 마찬가지인데, 0f만 false고 그 외 1.57 이나 3.14 같은건 뒤에 소수점 날리고 int형이랑 비슷한 형식으로 처리되는 느낌.
        //Debug.Log("numb2 :" + Convert.ToBoolean(numb2));
        //Debug.Log("numb3 :" + Convert.ToBoolean(numb3));
        //Debug.Log("numb4 :" + Convert.ToBoolean(numb4));
        //Debug.Log("numb5 :" + Convert.ToBoolean(numb5));

        //Debug.Log("Float 타입 테스트 : " + Convert.ToBoolean(flo));
        //// 0.1254 같은 식으로 1의 자리를 0으로 해도 0.0f가 아니므로 True를 반환
        //Debug.Log("Float 타입 테스트 0.0f: " + Convert.ToBoolean(flo2));
        //// 이건 예상대로 False가 나옴.

        //Debug.Log("strin1 : " + Convert.ToBoolean(strin1)); 
        //Debug.Log("strin2 : " + Convert.ToBoolean(strin2)); 
        //Debug.Log("strin3 : " + Convert.ToBoolean(strin3)); 
        //// 얘네는 FormatException 뜨면서 실행 안되는 듯?

        //string str1 = "123";
        //string str2 = "456";
        //Debug.Log($"String : {str1}{str2}"); // 아래랑 동작은 같음, 123456
        //Debug.Log("String : " + str1 + str2); // 위에랑 동작은 같음, 123456

        //int num1 = int.Parse(str1);
        //int num2 = int.Parse(str2);
        //Debug.Log("Int :" + num1 + num2); // 이건 덧셈이 안되고 단순히 이어붙여짐, 123456
        //Debug.Log("Int : " + (num1 + num2)); // 이건 덧셈이 되서 들어감, 579



        // int num3 = (int)str1; 얘네는 int.Parse 안쓰면 명시적이든 암시적이든 안됌
        // int num4 = str2; // ㅇㅇ

        //number1 = (int)number2; // 딸깍으로 형변환한 것, Explicit Casting(명시적 형변환)
        //Debug.Log(number1); // number2 변수는 소수점 없는 실수였기 때문에 딸깍 변환이 잘 됌.

        //number1 = (int)number3; // 이것도 딸깍 변환은 되는듯?
        //Debug.Log(number1); // 근데 반올림 개념이 없는 것 같음. 2.75f 기준 정수형 2로 나옴.
        //// number1 = number2; // 근데 이런식의 암시적 형변환은 컴파일러에서 막아버림

        //Vector3 vec = new Vector3(10, 20, 30); // 이건 굳이 f를 안 붙이는데, 이걸 암시적 형변환(Implicit Casting)이라고 함.
        //Vector3Int vecInt = new Vector3Int(10, 20, 30); // 근데 애초에 이렇게 벡터를 정수형으로 받아오는 방법이 있긴 하다고 함.

        //// 수학적인 기능
        //float number4 = Mathf.Floor(number3); // 내림 / 소수점 있으면 값 내려버림?
        //float number5 = Mathf.Ceil(number3); // 올림 / 소수점 있으면 값 올려버림?
        //float number6 = Mathf.Round(number3); // .5 부터 올라가고 .49까진 내려가는 반올림
        //// Math. <- c# 자체 기능
        //// Mathf. <- 유니티 기능

        //Debug.Log($"내림 Floor: {number4}");
        //Debug.Log($"올림 Ceil: {number5}"); 
        //Debug.Log($"반올림 Round: {number6}");

        //// number2 = (GameObject)number2; 이것처럼 뭐가됐든 못 바꾸는 타입의 경우엔 명시적 형변환으로도 안됌.

    }
}
