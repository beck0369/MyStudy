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

        Debug.Log($"��� : 3�� �������� {Squared(number1)} �Դϴ�.");
        Debug.Log($"��� : 34.2�� �������� {Squared(number2)} �Դϴ�.");
    }

    public static float Squared(float a)
    {
        return a * a;
    }
}
