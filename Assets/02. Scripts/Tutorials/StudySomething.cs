using UnityEngine;

public class StudySomething : MonoBehaviour
{

    public int currentLevel = 10;
    public int maxLevel = 99;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isMaxLevel = currentLevel >= maxLevel;
        // 비교 연산에 의한 결과를 bool 값으로 받는 코드. 맞으면 True고 틀리면 false로 변환되는.

        string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다.";
        // 삼항 연산자

        int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        currentLevel += levelPoint;

        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
