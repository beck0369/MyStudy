using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX10 : MonoBehaviour
{
    private void Start()
    {
        

        for (int i = 0; i < 5; i++)
        {
            string a = "";

            for (int j = 0; j <= i; j++)
            {
                a += "¡Ú";
            }

            for (int k = i; k < 4; k++)
            {
                a += "¡Ù";
            }

            Debug.Log(a);
        }
    }
}
