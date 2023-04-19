using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    private void Awake()
    {
        GameManager.instance.onInteract += OnInteractSetText;
        GameManager.instance.onStopInteract += DisableInfoText;
    }

    private void OnInteractSetText(IInteractable interactable)
    {
        //if(listInteractable.Count > 0)
        //{
        //    SetInfoText(listInteractable[0].InteractableName);
        //}

        SetInfoText(interactable.InteractableName);
    }

    private void SetInfoText(string itemName)
    {
        infoText.text = Constants.INFO_TEXT_STRING + itemName;
        if (!infoText.gameObject.activeInHierarchy)
        {
            infoText.gameObject.SetActive(true);
            infoText.transform.parent.gameObject.SetActive(true);
        }
    }

    private void DisableInfoText(IInteractable interactable)
    {
        //if(listInteractable.Count == 0)
        //{
        //    infoText.transform.parent.gameObject.SetActive(false);
        //}
        //else
        //{
        //    SetInfoText(listInteractable[0].InteractableName);
        //}
        if(interactable != null)
            SetInfoText(interactable.InteractableName);
        else
            infoText.transform.parent.gameObject.SetActive(false);
    }
}
