using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX5_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput1 = "60";
        string userInput2 = "60";

        int class123 = int.Parse(userInput1);
        int class4 = int.Parse(userInput2);

        int result123 = (class123 / 10) * 10;
        int result4 = (class4 / 10) * 10;

        string output1 = "";
        string output2 = "";

        switch(result123)
        {
            case 100:
                output1 = "합격입니다";
                break;
            case 90:
                output1 = "합격입니다";
                break;
            case 80:
                output1 = "합격입니다";
                break;
            case 70:
                output1 = "합격입니다";
                break;
            case 60:
                output1 = "합격입니다";
                break;
            case 50:
                output1 = "불합격입니다";
                break;
            case 40:
                output1 = "불합격입니다";
                break;
            case 30:
                output1 = "불합격입니다";
                break;
            case 20:
                output1 = "불합격입니다";
                break;
            case 10:
                output1 = "불합격입니다";
                break;
            case 0:
                output1 = "불합격입니다";
                break;
            default:
                output1 = "잘못된 숫자를 입력하셨습니다";
                break;
        }

        switch (result4)
        {
            case 100:
                output2 = "합격입니다";
                break;
            case 90:
                output2 = "합격입니다";
                break;
            case 80:
                output2 = "합격입니다";
                break;
            case 70:
                output2 = "합격입니다";
                break;
            case 60:
                output2 = "불합격입니다";
                break;
            case 50:
                output2 = "불합격입니다";
                break;
            case 40:
                output2 = "불합격입니다";
                break;
            case 30:
                output2 = "불합격입니다";
                break;
            case 20:
                output2 = "불합격입니다";
                break;
            case 10:
                output2 = "불합격입니다";
                break;
            case 0:
                output2 = "불합격입니다";
                break;
            default:
                output2 = "잘못된 숫자를 입력하셨습니다";
                break;
        }

        Debug.Log(output1);
        Debug.Log(output2);
    }
}
