using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPromptUI : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI _promptText;

    private void Start()
    {
        mainCamera = Camera.main;
        uiPanel.SetActive(false);
    }

    private void LateUpdate()
    {
        var rotation = mainCamera.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }

    public bool isDisplayed = false;

    public void SetUp(string promptText)
    {
        _promptText.text = promptText;
        uiPanel.SetActive(true);
        isDisplayed = true;
    }

    public void Close()
    {
        uiPanel.SetActive(false);
        isDisplayed = false;
    }
}
