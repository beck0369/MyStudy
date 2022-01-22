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
            Debug.Log("3의 배수입니다.");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
    }
}
