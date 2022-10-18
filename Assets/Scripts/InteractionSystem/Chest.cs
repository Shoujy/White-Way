using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable_1
{
    [SerializeField] private string prompt;

    public string InteractionPrompt => prompt;

    public bool Interact(Interactor_1 interactor)
    {
        Debug.Log("Opening chest!");
        return true;
    }
}
