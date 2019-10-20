using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPLayer2 : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Vector3 offset;
    private void LateUpdate()
    {
        transform.position = new Vector3(0,0,Player.position.z) + offset;
    }
}
