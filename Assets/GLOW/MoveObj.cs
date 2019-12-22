using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    Vector3 mOffset;
    float mzcord;
    bool beingTouched = false;
    //1440X720-18:9 Y(mouse/touch)->Z X(mouse/touch)->X

    private void OnMouseDown()
    {
        mzcord = Camera.main.WorldToScreenPoint(transform.position).z;
        mOffset = transform.position - GetmouseworldPos();
        beingTouched = true;
    }

    private Vector3 GetmouseworldPos()
    {
        Vector3 mousePoint = Input.mousePosition;//Debug.Log(Input.mousePosition);
        mousePoint.z = mzcord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        //Vector3 moveposGlobal = GetmouseworldPos() + mOffset;
        //transform.localPosition = new Vector3(moveposGlobal.x,1f,moveposGlobal.y);
        transform.localPosition = GetmouseworldPos() + mOffset;
    }
    private void OnMouseUp()
    {
        beingTouched = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag=="Cube") {
            Debug.Log("hre");
            if(!beingTouched)
            gameObject.GetComponent<MeshRenderer>().material.color = collision.gameObject.GetComponent<Renderer>().material.color;
        }
    }
}
