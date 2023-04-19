using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public InteractionComponent interaction;
    public InventoryComponent inventory;
    public PlayerMovement movement;

    private void Start()
    {
        interaction = GetComponentInChildren<InteractionComponent>();
        inventory = GetComponent<InventoryComponent>();
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interaction.listOfInteractables.Count > 0)
        {
            if(interaction.SelectedInteractable != null)
                interaction.SelectedInteractable.Interact(this);
        }

        if(Input.GetKeyDown(KeyCode.K) && interaction.listOfInteractables.Count > 1)
        {
            interaction.SwitchInteractableItem();
        }

        if(Input.GetKeyDown(KeyCode.Q) && inventory.items.Count > 0)
        {
            inventory.Drop(inventory.items[0]);
        }

        movement.GetInput();
    }
}
