using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    private float speed = 7f;
    private float turnSpeed = 150f;
    private float horizontalInput;
    private float verticalInput;
    private float Counter;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("PIZZA"))
        {
            Destroy(other.gameObject);
            Counter++;
            Debug.Log(message: $"Great {Counter}/17!");
        }
        if (other.gameObject.name.Contains("ENEMY"))
        {
            Destroy(gameObject);
            Debug.Log($"Oh...");
        }
    }
}
    
