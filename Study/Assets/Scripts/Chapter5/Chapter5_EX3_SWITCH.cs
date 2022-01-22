using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX3_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "21";
        string output = "";

        int number = int.Parse(userInput);
        int result = number % 3;

        switch(result)
        {
            case 0:
                output = "3의 배수입니다.";
                break;
            default:
                output = "3의 배수가 아닙니다.";
                break;
        }

        Debug.Log(output);
    }
}
