using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX3_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "21";

        int number = int.Parse(userInput);

        if(number % 3 == 0)
        {
            Debug.Log("3�� ����Դϴ�.");
        }
        else
        {
            Debug.Log("3�� ����� �ƴմϴ�.");
        }
    }
}
