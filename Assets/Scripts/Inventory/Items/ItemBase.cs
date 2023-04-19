using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : InteractableBase
{
    public ItemData data;
    public override string InteractableName { get => data.name; }

    public override void Interact(PlayerController controller)
    {
        Debug.Log("pickup");
        base.Interact(controller);
        controller.inventory.Pickup(data);
        Destroy(gameObject, 0.1f);
    }
}
