using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    //observer interact
    public delegate void OnInteract(IInteractable interactable);
    public OnInteract onInteract;

    public delegate void OnStopInteract(IInteractable interactable);
    public OnInteract onStopInteract;

}
