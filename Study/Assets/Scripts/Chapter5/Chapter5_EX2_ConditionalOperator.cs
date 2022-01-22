using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX2_ConditionalOperator : MonoBehaviour
{
    private void Start()
    {
        string userInput = "50";

        int number = int.Parse(userInput);

        string output = number >= 50 ? "50 이상의 수" : "50 미만의 수";

        Debug.Log(output);
    }
}
