using DevA;
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    // ProgrammerA pA = new ProgrammerA(); 
    // ������Ʈ�� ������Ʈ�� �� �ڵ带 �־�������� �ٷ� ����ó�� ��üȭ(��üȭ)�� �����൵ �ȴٰ� ��. �׸��� �ϸ� ������.

    public ProgrammerA pA;
    // �̷��Ը��ϸ� ����Ƽ ������ pA�� None���� �Ǹ� ���� ���� ������ �ν���.
    // �׷��� ����Ƽ �ν����Ϳ��� �ش� ������Ʈ�� �Ҵ� �ʿ�

    private void Start()
    {
        // pA.number1 = 0;
        pA.number2 = 20;
        // pA.number3 = 0;
        // pA.number4 = 0;
        //  pA.number5 = 0;
    }


}
