using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Camera thisCamera;
    [SerializeField] Vector3 Offset1;
    [SerializeField] Vector3 offset2;
    [SerializeField] bool buttonPressed=false;

    Vector3 newCameraPos,oldCameraPos;
    Vector3 lerp_offset1_offset2;

    private void Start()
    {
        lerp_offset1_offset2 = Offset1;
    }


    private void LateUpdate()
    {
        newCameraPos = new Vector3(0,0,Player.transform.position.z);


        if (Input.GetMouseButton(0))
        {
            //buttonPressed = true;
            //oldCameraPos = thisCamera.transform.position;
            lerp_offset1_offset2 = Vector3.Lerp(lerp_offset1_offset2, offset2, 0.2f);Debug.Log(lerp_offset1_offset2);
            thisCamera.transform.position = newCameraPos + lerp_offset1_offset2;

        }
        else {
            thisCamera.transform.position = newCameraPos + Offset1;
            lerp_offset1_offset2 = Offset1;
        }

       /* if (buttonPressed)
        {
            Vector3 lerp_offset1_offset2 = Vector3.Lerp(Offset1,offset2,0.5f);
            thisCamera.transform.position = newCameraPos + lerp_offset1_offset2;

            if (thisCamera.transform.position == (oldCameraPos + offset2)) buttonPressed = false;
        }
        else
        {
            thisCamera.transform.position = newCameraPos + Offset1;
        }*/
    }
}
