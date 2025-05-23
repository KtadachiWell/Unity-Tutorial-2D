using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1;
    public int number2;
    // public int number1, number2; µµ °¡´É

    void Start()
    {
        int PlusResult = Cal_PlusMethod();

        int MinusResult = Cal_MinusMethod();

        Debug.Log($"µ¡¼À ¿Ï·á, °ªÀº {PlusResult}, »¬¼À ¿Ï·á, °ªÀº {MinusResult}");

    }

    int Cal_PlusMethod()
    {
       int result = number1 + number2;

        return result;
    }
    int Cal_MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
