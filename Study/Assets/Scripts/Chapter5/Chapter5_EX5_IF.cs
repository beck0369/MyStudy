using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX5_IF : MonoBehaviour
{
    private void Start()
    {
        string userInput1 = "60";
        string userInput2 = "60";

        int class123 = int.Parse(userInput1);
        int class4 = int.Parse(userInput2);

        if(class123 >= 60 && class123 <= 100)
        {
            Debug.Log("합격입니다");
        }
        else if(class123 < 60 && class123 >= 0)
        {
            Debug.Log("불합격입니다");
        }
        else
        {
            Debug.Log("잘못된 숫자를 입력하셨습니다");
        }

        if(class4 >= 70 && class4 <= 100)
        {
            Debug.Log("합격입니다");
        }
        else if(class4 < 70 && class4 >= 0)
        {
            Debug.Log("불합격입니다");
        }
        else
        {
            Debug.Log("잘못된 숫자를 입력하셨습니다");
        }
    }
}
