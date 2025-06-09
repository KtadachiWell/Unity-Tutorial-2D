using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide } // �迭ó�� 0,1,2,3 ������ ���� ����.
    // public enum CalculationType { Plus = 10, Minus = 20, Multiply = 30, Divide=40 } // �̷����ϸ� �迭�� �ƴ϶� ������ ���� �־���� ���� ����
    public CalculationType calculationType = CalculationType.Plus;

    public int input1, input2, result;

    private void Start()
    {
        Debug.Log($"��� ��� : {Calculation()}");
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
