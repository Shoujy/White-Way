using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor_1 : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private InteractionPromptUI interactionPromptUI;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    private IInteractable_1 interactable;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders, interactableMask);

        if(numFound > 0)
        {
            interactable = colliders[0].GetComponent<IInteractable_1>();

            if(interactable != null)
            {
                if (!interactionPromptUI.isDisplayed)
                {
                    interactionPromptUI.SetUp(interactable.InteractionPrompt);
                }

                if (Input.GetKeyUp(KeyCode.E))
                {
                    interactable.Interact(this);
                }
            }
        }
        else
        {
            if(interactable != null)
            {
                interactable = null;
            }

            if (interactionPromptUI.isDisplayed)
            {
                interactionPromptUI.Close();
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }
}
