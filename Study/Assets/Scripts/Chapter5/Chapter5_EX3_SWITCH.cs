using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX3_SWITCH : MonoBehaviour
{
    private void Start()
    {
        string userInput = "21";
        string output = "";

        int number = int.Parse(userInput);
        int result = number % 3;

        switch(result)
        {
            case 0:
                output = "3�� ����Դϴ�.";
                break;
            default:
                output = "3�� ����� �ƴմϴ�.";
                break;
        }

        Debug.Log(output);
    }
}
