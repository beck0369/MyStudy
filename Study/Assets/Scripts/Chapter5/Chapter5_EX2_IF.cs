using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX2_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput = "50";

        int number = int.Parse(userInput);

        if(number <= 50)
        {
            Debug.Log("50 이상의 수");
        }
        else
        {
            Debug.Log("50 이하의 수");
        }    
    }
}
