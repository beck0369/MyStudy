using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX3_ConditionalOperator : MonoBehaviour
{
    private void Start()
    {
        string userInput = "21";

        int number = int.Parse(userInput);

        string output = number % 3 == 0 ? "3의 배수입니다." : "3의 배수가 아닙니다.";

        Debug.Log(output);
    }
}
