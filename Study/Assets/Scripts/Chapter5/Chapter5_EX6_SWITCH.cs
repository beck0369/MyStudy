using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX6_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput1 = "1";
        string userInput2 = "2";
        string userInput3 = "+";

        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);

        int output = 0;

        switch(userInput3)
        {
            case "+":
                output = number1 + number2;
                break;
            case "-":
                output = number1 - number2;
                break;
            case "*":
                output = number1 * number2;
                break;
            case "/":
                output = number1 / number2;
                break;
            case "%":
                output = number1 % number2;
                break;
        }

        Debug.Log(output);
    }
}
