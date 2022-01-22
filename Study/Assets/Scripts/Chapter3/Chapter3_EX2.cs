using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3_EX2 : MonoBehaviour
{
    private void Start()
    {
        string a = "2022";
        string b = "1996";

        int c = int.Parse(a);
        int d = int.Parse(b);

        Debug.Log($"현재년도는 {c} 입니다.");
        Debug.Log($"출생년도는 {d} 입니다.");
        Debug.Log($"나의나이는 {c - d + 1} 입니다.");
    }
}
