using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX7_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "7";
        string output = "";

        if(userInput == "1")
        {
            output = "1월은 : 31일 까지 있습니다.";
        }
        else if(userInput == "2")
        {
            output = "2월은 : 28일 까지 있습니다.";
        }
        else if (userInput == "3")
        {
            output = "3월은 : 31일 까지 있습니다.";
        }
        else if (userInput == "4")
        {
            output = "4월은 : 30일 까지 있습니다.";
        }
        else if (userInput == "5")
        {
            output = "5월은 : 31일 까지 있습니다.";
        }
        else if (userInput == "6")
        {
            output = "6월은 : 30일 까지 있습니다.";
        }
        else if (userInput == "7")
        {
            output = "7월은 : 31일 까지 있습니다.";
        }
        else if (userInput == "8")
        {
            output = "8월은 : 31일 까지 있습니다.";
        }
        else if (userInput == "9")
        {
            output = "9월은 : 30일 까지 있습니다.";
        }
        else if (userInput == "10")
        {
            output = "10월은 : 31일 까지 있습니다.";
        }
        else if (userInput == "11")
        {
            output = "11월은 : 30일 까지 있습니다.";
        }
        else if (userInput == "12")
        {
            output = "12월은 : 31일 까지 있습니다.";
        }
        else
        {
            output = "잘못입력하셨습니다.";
        }

        Debug.Log(output);
    }
}
