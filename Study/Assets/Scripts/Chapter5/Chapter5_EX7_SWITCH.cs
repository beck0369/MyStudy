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
                output = "1����: 31�� ���� �ֽ��ϴ�.";
                break;
            case "2":
                output = "2���� : 28�� ���� �ֽ��ϴ�.";
                break;
            case "3":
                output = "3���� : 31�� ���� �ֽ��ϴ�.";
                break;
            case "4":
                output = "4���� : 30�� ���� �ֽ��ϴ�.";
                break;
            case "5":
                output = "5���� : 31�� ���� �ֽ��ϴ�.";
                break;
            case "6":
                output = "6���� : 30�� ���� �ֽ��ϴ�.";
                break;
            case "7":
                output = "7���� : 31�� ���� �ֽ��ϴ�.";
                break;
            case "8":
                output = "8���� : 31�� ���� �ֽ��ϴ�.";
                break;
            case "9":
                output = "9���� : 30�� ���� �ֽ��ϴ�.";
                break;
            case "10":
                output = "10���� : 31�� ���� �ֽ��ϴ�.";
                break;
            case "11":
                output = "11���� : 30�� ���� �ֽ��ϴ�.";
                break;
            case "12":
                output = "12���� : 31�� ���� �ֽ��ϴ�.";
                break;
            default:
                output = "�߸��Է��ϼ̽��ϴ�.";
                break;
        }

        Debug.Log(output);
    }
}
