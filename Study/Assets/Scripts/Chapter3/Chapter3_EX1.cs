using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3_EX1 : MonoBehaviour
{
    private void Start()
    {
        string a = "30";
        string b = "40";

        int c = int.Parse(a);
        int d = int.Parse(b);

        Debug.Log($"사각형의 너비는 {c} 입니다.");
        Debug.Log($"사각형의 높이는 {d} 입니다.");
        Debug.Log($"사각형의 넓이는 : {c * d}");
    }
}
