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
            output = "1���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if(userInput == "2")
        {
            output = "2���� : 28�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "3")
        {
            output = "3���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "4")
        {
            output = "4���� : 30�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "5")
        {
            output = "5���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "6")
        {
            output = "6���� : 30�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "7")
        {
            output = "7���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "8")
        {
            output = "8���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "9")
        {
            output = "9���� : 30�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "10")
        {
            output = "10���� : 31�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "11")
        {
            output = "11���� : 30�� ���� �ֽ��ϴ�.";
        }
        else if (userInput == "12")
        {
            output = "12���� : 31�� ���� �ֽ��ϴ�.";
        }
        else
        {
            output = "�߸��Է��ϼ̽��ϴ�.";
        }

        Debug.Log(output);
    }
}
