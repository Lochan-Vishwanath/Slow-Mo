using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    Vector3 mOffset;
    float mzcord;
    bool beingTouched = false;
    Vector3 originalPos;

    //1440X720-18:9 Y(mouse/touch)->Z(Transform) X(mouse/touch)->X(Transform)

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
        if (beingTouched)
        {
            Vector3 moveposGlobal = GetmouseworldPos() + mOffset;
            transform.localPosition = new Vector3(moveposGlobal.x, 1f, moveposGlobal.y);
            transform.localPosition = GetmouseworldPos() + mOffset;
        }
    }
    private void OnMouseUp()
    {
        beingTouched = false;
        Debug.Log("hre");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Inside Collision");
        if (collision.gameObject.tag=="Cube") {
            if (!beingTouched)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = collision.gameObject.GetComponent<Renderer>().material.color;
                pphandler.starteffect = true;

            }
            beingTouched = false;
        }
    }
    private void Start()
    {
        originalPos = transform.position;
    }
    private void Update()
    {
        if (!beingTouched)
        {
            transform.position = Vector3.Lerp(transform.position,originalPos,0.05f);
        }
    }
}
