using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    private float speed = 2f;
    private float turnSpeed = 35f;
    private Vector3 derecha = Vector3.right;

    private void Update()
    {
        transform.Translate(derecha * speed * Time.deltaTime);
        if (transform.position.x >= 17)
        {
            derecha = -derecha;
        }
        if (transform.position.x <= -17)
        {
            derecha = -derecha;
        }
    }
}
