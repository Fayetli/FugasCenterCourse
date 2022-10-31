using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 0.7f;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        var desiredPos = target.position + offset;
        var smoothedPos = 
            Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothTime);
        transform.position = smoothedPos;
    }
}
