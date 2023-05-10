using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    private List<ItemData> items = new List<ItemData>();
    [SerializeField] private UIItemCard prefabItemCard;
    [SerializeField] private Transform itemsSection;
    private InventoryComponent inventory;

    private void Start()
    {
        inventory = GetComponentInParent<InventoryComponent>();
    }

    public void Open(List<ItemData> inventoryItems)
    {
        PopulateItemsSection(inventoryItems);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        gameObject.SetActive(true);
    }

    public void PopulateItemsSection(List<ItemData> inventoryItems)
    {
        ClearAll();
        items.AddRange(inventoryItems);
        foreach (ItemData item in items)
        {
            AddCard(item, this);
        }
    }

    public void Close() 
    {
        ClearListItems();
        DeleteAllChildren();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gameObject.SetActive(false);
    }

    private void ClearListItems()
    {
        items.Clear();
    }

    public void FilterItems(int enumIndex)
    {
        DeleteAllChildren();
        if(enumIndex == -1)
        {
            PopulateItemsSection(items);
        }
        else
        {
            foreach(var item in items)
            {
                if (item.Type == (ItemEnums.ItemType)enumIndex)
                {
                    AddCard(item, this);
                }
            }
        }
    }

    private void ClearAll()
    {
        ClearListItems();
        DeleteAllChildren();
    }

    private void DeleteAllChildren()
    {
        foreach (Transform child in itemsSection)
        {
            if (child != itemsSection) Destroy(child.gameObject);
        }
    }

    private void AddCard(ItemData item, UIInventory uiInventory)
    {
        var card = Instantiate(prefabItemCard, itemsSection);
        card.Setup(item, uiInventory);
    }

    public void EquipItem(ItemData item)
    {
        inventory.EquipItem(item);
    }
}
