using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement2 : MonoBehaviour
{
    [SerializeField] float speed=1;
    Rigidbody myRb;

    private void Start()
    {
        myRb = GetComponent<Rigidbody>();
        myRb.velocity = Vector3.forward * speed;
    }
    private void Update()
    {
        myRb.velocity = Vector3.forward * speed;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(-4, 0.5f, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(4, 0.5f, transform.position.z);
        }

        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            myRb.velocity = Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myRb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.E)) {
            myRb.velocity = Vector3.forward * speed;
        }*/

        
    }
}
