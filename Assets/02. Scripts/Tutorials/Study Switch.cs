using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide } // 배열처럼 0,1,2,3 식으로 접근 가능.
    // public enum CalculationType { Plus = 10, Minus = 20, Multiply = 30, Divide=40 } // 이렇게하면 배열이 아니라 개별의 값을 넣어놓고 접근 가능
    public CalculationType calculationType = CalculationType.Plus;

    public int input1, input2, result;

    private void Start()
    {
        Debug.Log($"계산 결과 : {Calculation()}");
    }

    int Calculation()
    {
        switch (calculationType)
        {
            case CalculationType.Plus:
                result = input1 + input2;
                break;
            case CalculationType.Minus:
                result = input1 - input2;
                break;
            case CalculationType.Multiply:
                result = input1 * input2;
                break;
            case CalculationType.Divide:
                result = input1 / input2;
                break;
        }

        return result;
    }
}
