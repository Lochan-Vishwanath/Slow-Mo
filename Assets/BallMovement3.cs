using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement3 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity == new Vector3(0, 0, 0)) {
            Debug.Log("Velocity is Zero");
        }
    }
}
