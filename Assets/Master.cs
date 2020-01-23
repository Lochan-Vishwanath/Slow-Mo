using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    public GameObject[] Moveable;
    public static int Totalnoofobjs=0;

    void Start()
    {
        Moveable = GameObject.FindGameObjectsWithTag("Cube");
        Totalnoofobjs = Moveable.Length;
        Debug.Log(Totalnoofobjs);
    }

    void Update()
    {
        
    }
}
