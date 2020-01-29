using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    Vector3 mOffset;
    float mzcord;
    bool beingTouched = false;
    bool StopMovement = false;
    Vector3 originalPos;
    public bool ColorMatched;
    public Color finalColor;
    public Color InitialColor;
    MeshRenderer Renderer;

    //1440X720-18:9 Y(mouse/touch)->Z(Transform) X(mouse/touch)->X(Transform)

    private void OnMouseDown()
    {
        mzcord = Camera.main.WorldToScreenPoint(transform.position).z;
        mOffset = transform.position - GetmouseworldPos();
        beingTouched = true;
        StopMovement = false;
    }

    private Vector3 GetmouseworldPos()
    {
        Vector3 mousePoint = Input.mousePosition;//Debug.Log(Input.mousePosition);
        mousePoint.z = mzcord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        if (beingTouched && !StopMovement)
        {
            Vector3 moveposGlobal = GetmouseworldPos() + mOffset;
            transform.localPosition = new Vector3(moveposGlobal.x, 1f, moveposGlobal.y);
            transform.localPosition = GetmouseworldPos() + mOffset;
        }
    }
    private void OnMouseUp()
    {
        beingTouched = false;
        StopMovement = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        StopMovement = true;
        if (collision.gameObject.tag=="Cube") {
            if (!beingTouched)
            {
                Renderer.material.color = collision.gameObject.GetComponent<Renderer>().material.color;
                pphandler.starteffect = true;
                Master.checknow=true;
                if (Renderer.material.color.Equals(finalColor))
                {
                    ColorMatched = true;
                }
                else
                {
                    ColorMatched = false;
                }
            }
            beingTouched = false;
        }
        if (collision.gameObject.tag == "Cube2")
        {
            if (!beingTouched)
            {
                Renderer.material.color = collision.gameObject.GetComponent<Renderer>().material.color;
                Master.checknow = true;
                pphandler.starteffect = true;
            }
        }
    }
    private void Start()
    {
        originalPos = transform.position;
        Renderer = GetComponent<MeshRenderer>();
        Renderer.material.color = InitialColor;
        Debug.Log(Renderer.material.color.ToString());
        Debug.Log(finalColor.ToString());

        if (string.Equals (Renderer.material.color.ToString(),finalColor.ToString()))
       {
            Debug.Log("here");
            ColorMatched = true;
        }
       else
       {
            Debug.Log("here2");
            ColorMatched = false;
        }
    }
    private void Update()
    {
        if (!beingTouched)
        {
            transform.position = Vector3.Lerp(transform.position,originalPos,0.1f);
        }
    }
}
