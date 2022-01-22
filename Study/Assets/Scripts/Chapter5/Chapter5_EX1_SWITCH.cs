using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX1_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "78";

        int a = int.Parse(userInput);

        int number = (a / 10)* 10;

        string output = "";

        switch(number)
        {
            case 100:
                output = "A";
                break;
            case 90:
                output = "A";
                break;
            case 80:
                output = "B";
                break;
            case 70:
                output = "C";
                break;
            case 60:
                output = "F";
                break;
            case 50:
                output = "F";
                break;
            case 40:
                output = "F";
                break;
            case 30:
                output = "F";
                break;
            case 20:
                output = "F";
                break;
            case 10:
                output = "F";
                break;
            case 0:
                output = "F";
                break;
            default:
                output = "잘못된 숫자를 입력하셨습니다.";
                break;
        }
        Debug.Log(output);
    }
}
