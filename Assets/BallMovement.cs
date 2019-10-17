using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody myrb;
    private int velocityVAR;
    public int DefaultVelocity;
    public int OnclickSpeed;

    private void Start()
    {
        myrb = GetComponent<Rigidbody>();
        velocityVAR = DefaultVelocity;
        myrb.velocity = Vector3.forward * velocityVAR;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X)) {
            //transform.LookAt(Input.mousePosition);
            myrb.velocity = Vector3.forward * 25;
            
        }
        if (Input.GetMouseButton(0))
        {
            velocityVAR = OnclickSpeed;
            myrb.velocity = Vector3.forward * velocityVAR;
            //myrb.AddForce(Vector3.forward * velocityVAR,ForceMode.Acceleration);
        }
        else {
            if (velocityVAR != DefaultVelocity)
            {
                myrb.velocity = Vector3.forward * velocityVAR;
                velocityVAR = DefaultVelocity;
            }

        }
        //Debug.Log(velocityVAR);
    }
}
