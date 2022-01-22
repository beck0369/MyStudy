using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX1_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "78";

        int number = int.Parse(userInput);

        if(number >= 90 && number <= 100)
        {
            Debug.Log("A");
        }
        else if(number >= 80)
        {
            Debug.Log("B");
        }
        else if(number >= 70)
        {
            Debug.Log("C");
        }
        else if(number <= 69 && number >= 0)
        {
            Debug.Log("F");
        }
        else
        {
            Debug.Log("잘못된 숫자를 입력하셨습니다.");
        }
    }
}
