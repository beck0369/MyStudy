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

        Debug.Log($"�簢���� �ʺ�� {c} �Դϴ�.");
        Debug.Log($"�簢���� ���̴� {d} �Դϴ�.");
        Debug.Log($"�簢���� ���̴� : {c * d}");
    }
}
