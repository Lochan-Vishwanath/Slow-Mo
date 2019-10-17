using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    Vector2 DeltaPos, lastmouseposition;
    [SerializeField] float Magnitude=1;

    private void Start()
    {
        DeltaPos = Vector2.zero;
    }

    private void Update()
    {
        DeltaPos = Vector2.zero;
        if (Input.GetMouseButton(0))
        {
            Vector2 currentMousepos = Input.mousePosition;
            if (lastmouseposition == Vector2.zero) lastmouseposition = currentMousepos;

            DeltaPos = currentMousepos - lastmouseposition;//Debug.Log(DeltaPos);
            lastmouseposition = currentMousepos;
            DeltaPos.y = 0;

            if (currentMousepos.x > lastmouseposition.x) transform.position -= new Vector3(DeltaPos.x,DeltaPos.y,0)*Magnitude;
            else transform.position += new Vector3(DeltaPos.x, DeltaPos.y, 0)*Magnitude;

            Debug.Log(transform.position);

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
