using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX8_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "01��";
        string output = "";

        switch(userInput)
        {
            case "01��":
                output = "12�� ~ 02�� : �ܿ�";
                break;
            case "02��":
                output = "12�� ~ 02�� : �ܿ�";
                break;
            case "03��":
                output = "03�� ~ 05�� : ��";
                break;
            case "04��":
                output = "03�� ~ 05�� : ��";
                break;
            case "05��":
                output = "03�� ~ 05�� : ��";
                break;
            case "06��":
                output = "06�� ~ 08�� : ����";
                break;
            case "07��":
                output = "06�� ~ 08�� : ����";
                break;
            case "08��":
                output = "06�� ~ 08�� : ����";
                break;
            case "09��":
                output = "09�� ~ 11�� : ����";
                break;
            case "10��":
                output = "09�� ~ 11�� : ����";
                break;
            case "11��":
                output = "09�� ~ 11�� : ����";
                break;
            case "12��":
                output = "12�� ~ 02�� : �ܿ�";
                break;
            default:
                output = "�߸��Է��ϼ̽��ϴ�.";
                break;
        }

        Debug.Log(output);
    }
}
