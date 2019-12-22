using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthOfCyclinder : MonoBehaviour
{
    float dist_btw_ball_n_plane;
    [SerializeField] Transform ball, plane;

    private void LateUpdate()
    {
        dist_btw_ball_n_plane = ball.position.y - plane.position.y;
        transform.localScale = new Vector3(transform.localScale.x, dist_btw_ball_n_plane / 2, transform.localScale.z);
    }
}
