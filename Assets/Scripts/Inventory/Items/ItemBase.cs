using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : InteractableBase
{
    public ItemData data;

    public override void Interact(PlayerController controller)
    {
        base.Interact(controller);
        controller.inventory.Pickup(data);
        Destroy(gameObject, 0.1f);
    }
}
