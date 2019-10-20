using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    Vector3 DeltaPos, lastmouseposition;
    [SerializeField] float Magnitude=1;

    private void Start()
    {
        DeltaPos = Vector2.zero;
    }

    private void Update()
    {
        DeltaPos = Vector3.zero;
        Debug.Log(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousepos = Input.mousePosition;
            if (lastmouseposition == Vector3.zero) lastmouseposition = currentMousepos;

            DeltaPos = currentMousepos - lastmouseposition;//Debug.Log(DeltaPos);
            lastmouseposition = currentMousepos;
            //DeltaPos.y = 0;

            if (currentMousepos.x > lastmouseposition.x) transform.position -= new Vector3(DeltaPos.x,0,DeltaPos.y)*Magnitude;
            else transform.position += new Vector3(DeltaPos.x, 0, DeltaPos.y)*Magnitude;

            //Debug.Log(transform.position);

        }
        else {
            lastmouseposition = Vector2.zero;
        }
    }

    private void LateUpdate()
    {
        Vector3 pos = transform.position;

        if (transform.position.x < -5)
        {
            pos.x = -5;
        }else if (transform.position.x > 5)
        {
            pos.x = 5;
        }

        transform.position = pos;
    }
}
