using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX6_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput1 = "1";
        string userInput2 = "2";
        string userInput3 = "+";

        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);

        int output = 0;

        if(userInput3 == "+")
        {
            output = number1 + number2;
        }
        else if(userInput3 == "-")
        {
            output = number1 - number2;
        }
        else if(userInput3 == "*")
        {
            output = number1 * number2;
        }
        else if(userInput3 == "/")
        {
            output = number1 / number2;
        }
        else if(userInput3 == "%")
        {
            output = number1 % number2;
        }
        else
        {
            Debug.Log("잘못입력하셨습니다.");
        }

        Debug.Log(output);
    }
}
