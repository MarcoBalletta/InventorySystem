using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBase : MonoBehaviour, IInteractable
{
    public IInteractable.SpottedItem onSpottedItem { get; set; }
    public IInteractable.UnspottedItem onUnspottedItem { get; set; }

    public virtual void Interact(PlayerController player)
    {
        onUnspottedItem(this);
    }
}
