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

        Debug.Log($"����⵵�� {c} �Դϴ�.");
        Debug.Log($"����⵵�� {d} �Դϴ�.");
        Debug.Log($"���ǳ��̴� {c - d + 1} �Դϴ�.");
    }
}
