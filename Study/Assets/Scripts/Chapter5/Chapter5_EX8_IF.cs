using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX8_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "01월";
        string output = "";

        if(userInput == "01월")
        {
            output = "12월 ~ 02월 : 겨울";
        }
        else if(userInput == "02월")
        {
            output = "12월 ~ 02월 : 겨울";
        }
        else if (userInput == "03월")
        {
            output = "03월 ~ 05월 : 봄";
        }
        else if (userInput == "04월")
        {
            output = "03월 ~ 05월 : 봄";
        }
        else if (userInput == "05월")
        {
            output = "03월 ~ 05월 : 봄";
        }
        else if (userInput == "06월")
        {
            output = "06월 ~ 08월 : 여름";
        }
        else if (userInput == "07월")
        {
            output = "06월 ~ 08월 : 여름";
        }
        else if (userInput == "08월")
        {
            output = "06월 ~ 08월 : 여름";
        }
        else if (userInput == "09월")
        {
            output = "09월 ~ 11월 : 가을";
        }
        else if (userInput == "10월")
        {
            output = "09월 ~ 11월 : 가을";
        }
        else if (userInput == "11월")
        {
            output = "09월 ~ 11월 : 가을";
        }
        else if (userInput == "12월")
        {
            output = "12월 ~ 02월 : 겨울";
        }
        else
        {
            output = "잘못입력하셨습니다.";
        }

        Debug.Log(output);
    }
}
