using DevA;
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    // ProgrammerA pA = new ProgrammerA(); 
    // 오브젝트에 컴포넌트로 이 코드를 넣어버렸으면 바로 윗줄처럼 객체화(실체화)를 안해줘도 된다고 함. 그리고 하면 오류남.

    public ProgrammerA pA;
    // 이렇게만하면 유니티 내에서 pA가 None으로 되며 값이 없는 것으로 인식함.
    // 그래서 유니티 인스펙터에서 해당 오브젝트를 할당 필요

    private void Start()
    {
        // pA.number1 = 0;
        pA.number2 = 20;
        // pA.number3 = 0;
        // pA.number4 = 0;
        //  pA.number5 = 0;
    }


}
