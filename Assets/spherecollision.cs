using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecollision : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float force=10f;
    //public float power = 1f, Radius = 1f, upmodifier = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * force;
        Vector3 point = transform.position;
        //rb.AddExplosionForce(power, new Vector3(point.x,point.y-3,point.z), Radius, upmodifier, ForceMode.Impulse);
    }
}
