using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter6_EX2 : MonoBehaviour
{
    private void Start()
    {
        string a = "3";
        string b = "4";
        string c = "2.4";
        string d = "3.1";

        float e = float.Parse(a);
        float f = float.Parse(b);
        float g = float.Parse(c);
        float h = float.Parse(d);

        Debug.Log($"{e} + {f} = {Plus(e, f)}");
        Debug.Log($"{g} + {h} = {Plus(g, h)}");
    }

    public static float Plus(float a, float b)
    {
        return a + b;
    }
}
