using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Animator myAnim;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            myAnim.SetBool("ON",true);
        }
        else
        {
            myAnim.SetBool("ON",false);
        }
    }
}
