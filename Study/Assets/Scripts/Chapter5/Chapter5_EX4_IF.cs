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
            Debug.Log($"최대값 : {d}");
        }
        else if(e > d && e > f)
        {
            Debug.Log($"최대값 : {e}");
        }
        else
        {
            Debug.Log($"최대값 : {f}");
        }

        if(d < e && d < f)
        {
            Debug.Log($"최소값 : {d}");
        }
        else if(e > d && e > f)
        {
            Debug.Log($"최소값 : {e}");
        }
        else
        {
            Debug.Log($"최소값 : {f}");
        }

        Debug.Log($"합계 : {d + e + f}");
        Debug.Log($"평균 : {(d + e + f) / 3}");
    }
}
