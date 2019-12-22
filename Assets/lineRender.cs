using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRender : MonoBehaviour
{
    public Transform plane;
    LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
        
    }

    private void LateUpdate()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, new Vector3(transform.position.x,plane.position.y,transform.position.z));

    }
}
