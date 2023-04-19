using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionComponent : MonoBehaviour
{
    public List<IInteractable> listOfInteractables = new List<IInteractable>();
    private IInteractable selectedInteractable;

    public IInteractable SelectedInteractable { get => selectedInteractable; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IInteractable interactable))
        {
            //interactable.onUnspottedItem -= Unspotted;
            interactable.onSpottedItem += Spotted;
            interactable.onUnspottedItem += Unspotted;
            interactable.onSpottedItem(interactable);
            GameManager.instance.onInteract(selectedInteractable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger");
        if (other.TryGetComponent(out IInteractable interactable))
        {
            interactable.onSpottedItem -= Spotted;
            interactable.onUnspottedItem(interactable);
            //GameManager.instance.onStopInteract(selectedInteractable);
        }
    }

    private void Spotted(IInteractable interactable) 
    {
        listOfInteractables.Add(interactable);
        if (listOfInteractables.Count == 1) selectedInteractable = interactable;
    }

    private void Unspotted(IInteractable interactable)
    {
        //interactablesSelected.Add(interactable);
        int index = listOfInteractables.IndexOf(interactable);
        listOfInteractables.Remove(interactable);
        listOfInteractables.TrimExcess();
        if (listOfInteractables.Count == 0) selectedInteractable = null;
        else 
        {
            if (index >= listOfInteractables.Count) index--;
            selectedInteractable = listOfInteractables[index];
        }
        interactable.onUnspottedItem -= Unspotted;
        GameManager.instance.onStopInteract(selectedInteractable);
    }

    public void SwitchInteractableItem()
    {
        int i = listOfInteractables.IndexOf(selectedInteractable);
        i++;
        if (i >= listOfInteractables.Count)   i = 0;
        selectedInteractable = listOfInteractables[i];
        GameManager.instance.onInteract(selectedInteractable);
    }
}
