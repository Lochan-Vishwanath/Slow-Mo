using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosive : MonoBehaviour
{
    public Rigidbody myrb;// Start is called before the first frame update
    public float power = 1f, Radius = 1f, upmodifier = 1f;
    void Start()
    {
        myrb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        
            Collider[] colliders = Physics.OverlapSphere(transform.position, Radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null) rb.AddExplosionForce(power, transform.position, Radius, upmodifier, ForceMode.Impulse);
            }
            //myrb.AddExplosionForce(power,transform.position,Radius,upmodifier,ForceMode.Impulse);

        

    }
}
