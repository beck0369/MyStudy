using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX9 : MonoBehaviour
{
    private void Start()
    {
        int a = 0;

        for (int i = 1; i < 11; i++)
        {
            if(i % 3 == 0)
            {
                Debug.Log(i);
                a += i;
            }
        }
        Debug.Log(a);
    }
}
