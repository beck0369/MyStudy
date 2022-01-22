using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter6_EX1 : MonoBehaviour
{
    private void Start()
    {
        string userInpur1 = "3";
        string userInpur2 = "34.2";

        float number1 = float.Parse(userInpur1);
        float number2 = float.Parse(userInpur2);

        Debug.Log($"결과 : 3의 제곱값은 {Squared(number1)} 입니다.");
        Debug.Log($"결과 : 34.2의 제곱값은 {Squared(number2)} 입니다.");
    }

    public static float Squared(float a)
    {
        return a * a;
    }
}
