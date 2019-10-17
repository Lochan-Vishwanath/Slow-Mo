using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Camera thisCamera;
    [SerializeField] Vector3 Offset1;
    [SerializeField] Vector3 offset2;

    private void LateUpdate()
    {
        Vector3 newCameraPos = new Vector3(0, 0, Player.transform.position.z);
        thisCamera.transform.position = newCameraPos + Offset1;
        if (Input.GetMouseButton(0)) {

        }
    }
}
