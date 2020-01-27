using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    public GameObject[] Moveable;
    public static int Totalnoofobjs=0;
    int count=0;
    public static bool checknow = false;

    void Start()
    {
        Moveable = GameObject.FindGameObjectsWithTag("Cube");
        Totalnoofobjs = Moveable.Length;
        Application.targetFrameRate = 60;
        Debug.Log(Application.targetFrameRate);
    }

    void Update()
    {
        if (checknow == true)
        {
            foreach (GameObject a in Moveable)
            {
                if (a.GetComponent<MoveObj>().ColorMatched)
                {
                    count++;
                }
            }
            if (count == Moveable.Length)
            {
                //NEXT LEVEL
                Debug.Log("NEXT LEVEL");
            }
            checknow = false;
        }
    }
}
