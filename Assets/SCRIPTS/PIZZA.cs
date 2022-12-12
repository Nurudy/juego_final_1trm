using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIZZA : MonoBehaviour
{
    private float turnSpeed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }
}
