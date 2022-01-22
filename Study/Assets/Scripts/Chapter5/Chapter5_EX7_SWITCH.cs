using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX7_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "7";
        string output = "";

        switch(userInput)
        {
            case "1":
                output = "1월은: 31일 까지 있습니다.";
                break;
            case "2":
                output = "2월은 : 28일 까지 있습니다.";
                break;
            case "3":
                output = "3월은 : 31일 까지 있습니다.";
                break;
            case "4":
                output = "4월은 : 30일 까지 있습니다.";
                break;
            case "5":
                output = "5월은 : 31일 까지 있습니다.";
                break;
            case "6":
                output = "6월은 : 30일 까지 있습니다.";
                break;
            case "7":
                output = "7월은 : 31일 까지 있습니다.";
                break;
            case "8":
                output = "8월은 : 31일 까지 있습니다.";
                break;
            case "9":
                output = "9월은 : 30일 까지 있습니다.";
                break;
            case "10":
                output = "10월은 : 31일 까지 있습니다.";
                break;
            case "11":
                output = "11월은 : 30일 까지 있습니다.";
                break;
            case "12":
                output = "12월은 : 31일 까지 있습니다.";
                break;
            default:
                output = "잘못입력하셨습니다.";
                break;
        }

        Debug.Log(output);
    }
}
