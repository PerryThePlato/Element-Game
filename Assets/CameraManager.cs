using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform targetTransform;
    private Vector3 cameraFollowVelocity = Vector3.zero;
    public float followSpeed = 0.2f;

    private void Awake()
    {
        targetTransform = FindObjectOfType<PlayerManager>().transform;
    }
    public void FollowTarget()
    {
        Vector3 targetPosition = Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, followSpeed);

        transform.position = targetPosition;
    }


    public void RotateCamera()
    {
        
    }
}