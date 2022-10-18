using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public PlayerManager playerManager;

    private Vector3 cameraFollowVelocity = Vector3.zero;
    public float cameraFollowSpeed = 2;

    private void Awake()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    public void HandleAllCameraMovement()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 targetPosition = Vector3.SmoothDamp
            (transform.position, playerManager.transform.position, ref cameraFollowVelocity, cameraFollowSpeed);

        transform.position = targetPosition;
    }
}
