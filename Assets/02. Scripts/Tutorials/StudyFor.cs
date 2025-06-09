using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyFor : MonoBehaviour
{

    // public int[] arrayInt = new int[5];
    // public List<int> listInt = new List<int>();
    void Start()
    {
        /*for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            Debug.Log(i + "ÀÔ´Ï´Ù");
        }*/

        /* for (int i = 0; i < arrayInt.Length; i++)
         {
             Debug.Log(arrayInt[i]);
         }*/

        /*for (int i = 0; i < listInt.Count; i++)
        {
            Debug.Log(listInt[i]);
        }*/

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"{i} / {j}");
            }
        }

    }
}
