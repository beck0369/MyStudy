using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX4_IF : MonoBehaviour
{
    private void Start()
    {
        string a = "1";
        string b = "2";
        string c = "3";

        int d = int.Parse(a);
        int e = int.Parse(b);
        int f = int.Parse(c);

        if(d > e && d > f)
        {
            Debug.Log($"�ִ밪 : {d}");
        }
        else if(e > d && e > f)
        {
            Debug.Log($"�ִ밪 : {e}");
        }
        else
        {
            Debug.Log($"�ִ밪 : {f}");
        }

        if(d < e && d < f)
        {
            Debug.Log($"�ּҰ� : {d}");
        }
        else if(e > d && e > f)
        {
            Debug.Log($"�ּҰ� : {e}");
        }
        else
        {
            Debug.Log($"�ּҰ� : {f}");
        }

        Debug.Log($"�հ� : {d + e + f}");
        Debug.Log($"��� : {(d + e + f) / 3}");
    }
}
