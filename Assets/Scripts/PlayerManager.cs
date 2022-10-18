using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    GameManager gameManager;
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;
    CameraManager cameraManager;


    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        cameraManager = FindObjectOfType<CameraManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovements();
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("GameStart"))
        {
            gameManager.GoToNewScene();
        }
    }
}
