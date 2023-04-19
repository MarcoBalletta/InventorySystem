using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string InteractableName{ get; }

    public delegate void SpottedItem(IInteractable interactable);
    public SpottedItem onSpottedItem { get; set; }

    public delegate void UnspottedItem(IInteractable interactable);
    public UnspottedItem onUnspottedItem { get; set; }

    public void Interact(PlayerController player);
}
