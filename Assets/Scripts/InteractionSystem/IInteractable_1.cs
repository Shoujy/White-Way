using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable_1
{
    public string InteractionPrompt { get; }
    public bool Interact(Interactor_1 interactor);
}
