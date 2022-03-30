using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerpole : MonoBehaviour
{
    public GameObject[] obstacles;

    private void OnEnable()
    {

        for (int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 2) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }
}
