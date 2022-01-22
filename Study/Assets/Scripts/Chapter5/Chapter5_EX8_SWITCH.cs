using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX8_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "01월";
        string output = "";

        switch(userInput)
        {
            case "01월":
                output = "12월 ~ 02월 : 겨울";
                break;
            case "02월":
                output = "12월 ~ 02월 : 겨울";
                break;
            case "03월":
                output = "03월 ~ 05월 : 봄";
                break;
            case "04월":
                output = "03월 ~ 05월 : 봄";
                break;
            case "05월":
                output = "03월 ~ 05월 : 봄";
                break;
            case "06월":
                output = "06월 ~ 08월 : 여름";
                break;
            case "07월":
                output = "06월 ~ 08월 : 여름";
                break;
            case "08월":
                output = "06월 ~ 08월 : 여름";
                break;
            case "09월":
                output = "09월 ~ 11월 : 가을";
                break;
            case "10월":
                output = "09월 ~ 11월 : 가을";
                break;
            case "11월":
                output = "09월 ~ 11월 : 가을";
                break;
            case "12월":
                output = "12월 ~ 02월 : 겨울";
                break;
            default:
                output = "잘못입력하셨습니다.";
                break;
        }

        Debug.Log(output);
    }
}
