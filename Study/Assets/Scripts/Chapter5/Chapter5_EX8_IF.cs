using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX8_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "01��";
        string output = "";

        if(userInput == "01��")
        {
            output = "12�� ~ 02�� : �ܿ�";
        }
        else if(userInput == "02��")
        {
            output = "12�� ~ 02�� : �ܿ�";
        }
        else if (userInput == "03��")
        {
            output = "03�� ~ 05�� : ��";
        }
        else if (userInput == "04��")
        {
            output = "03�� ~ 05�� : ��";
        }
        else if (userInput == "05��")
        {
            output = "03�� ~ 05�� : ��";
        }
        else if (userInput == "06��")
        {
            output = "06�� ~ 08�� : ����";
        }
        else if (userInput == "07��")
        {
            output = "06�� ~ 08�� : ����";
        }
        else if (userInput == "08��")
        {
            output = "06�� ~ 08�� : ����";
        }
        else if (userInput == "09��")
        {
            output = "09�� ~ 11�� : ����";
        }
        else if (userInput == "10��")
        {
            output = "09�� ~ 11�� : ����";
        }
        else if (userInput == "11��")
        {
            output = "09�� ~ 11�� : ����";
        }
        else if (userInput == "12��")
        {
            output = "12�� ~ 02�� : �ܿ�";
        }
        else
        {
            output = "�߸��Է��ϼ̽��ϴ�.";
        }

        Debug.Log(output);
    }
}
