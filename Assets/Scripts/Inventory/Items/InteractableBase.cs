using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBase : MonoBehaviour, IInteractable
{
    //public string interactableName;
    public IInteractable.SpottedItem onSpottedItem { get; set; }
    public IInteractable.UnspottedItem onUnspottedItem { get; set; }
    [field: SerializeField] public virtual string InteractableName { get; private set; }

    public virtual void Interact(PlayerController player)
    {
        onUnspottedItem(this);
    }
}
