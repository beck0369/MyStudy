using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX3_ConditionalOperator : MonoBehaviour
{
    private void Start()
    {
        string userInput = "21";

        int number = int.Parse(userInput);

        string output = number % 3 == 0 ? "3�� ����Դϴ�." : "3�� ����� �ƴմϴ�.";

        Debug.Log(output);
    }
}
