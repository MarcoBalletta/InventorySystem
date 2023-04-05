using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionComponent : MonoBehaviour
{
    public List<IInteractable> interactablesSelected = new List<IInteractable>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IInteractable interactable))
        {
            //interactable.onUnspottedItem -= Unspotted;
            interactable.onSpottedItem += Spotted;
            interactable.onUnspottedItem += Unspotted;
            interactable.onSpottedItem(interactable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out IInteractable interactable))
        {
            interactable.onSpottedItem -= Spotted;
            interactable.onUnspottedItem(interactable);
        }
    }

    private void Spotted(IInteractable interactable) 
    {
        interactablesSelected.Add(interactable);
    }

    private void Unspotted(IInteractable interactable)
    {
        //interactablesSelected.Add(interactable);
        interactablesSelected.Remove(interactable);
        interactablesSelected.TrimExcess();
    }
}
