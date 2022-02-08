using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 60f;

    private void Start()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
