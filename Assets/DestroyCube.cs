using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    ScreenShake ss;
    //public GameObject pf;
    
   
    private void Start()
    {
        ss = Camera.main.GetComponent<ScreenShake>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("HERE1");
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("HERE");
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up * 15f;
            //collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(power, collision.transform.position, Radius, upmodifier, ForceMode.Impulse);
            ss.shakeScreen();
            //Instantiate(pf,transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
