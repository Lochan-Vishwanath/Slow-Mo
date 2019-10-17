using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody myrb;
    [SerializeField] private int velocityVAR;

    private void Start()
    {
        myrb = GetComponent<Rigidbody>();
        velocityVAR = 10;
        myrb.velocity = Vector3.forward * velocityVAR;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            velocityVAR = 350;
            myrb.velocity = Vector3.forward * velocityVAR;
            //myrb.AddForce(Vector3.forward * velocityVAR,ForceMode.Acceleration);
        }
        else {
            if (velocityVAR != 10)
            {
                velocityVAR = 10;
                myrb.velocity = Vector3.forward * velocityVAR;
            }

        }
    }
}
