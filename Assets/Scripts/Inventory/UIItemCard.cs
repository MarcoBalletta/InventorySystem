using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItemCard : MonoBehaviour, IPointerClickHandler
{
    private UIInventory uIInventory;
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemType;
    [SerializeField] private TextMeshProUGUI itemCost;
    [SerializeField] private Image itemIcon;
    private GameObject prefabToEquip;
    private ItemData data;

    public void Setup(ItemData data, UIInventory ui)
    {
        this.data = data;
        itemName.text = data.name;
        itemType.text = data.Type.ToString();
        itemCost.text = data.SellValue.ToString();
        itemIcon.sprite = data.Icon;
        prefabToEquip = data.EquipItem;
        uIInventory = ui;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (prefabToEquip == null) return;

        uIInventory.EquipItem(data);
    }
}
