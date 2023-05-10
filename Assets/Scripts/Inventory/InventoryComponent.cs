using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>();
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private Transform leftSocket;
    [SerializeField] private Transform rightSocket;
    private Dictionary<Transform, ItemData> equippedData = new Dictionary<Transform, ItemData>();

    private void Start()
    {
        PopulateDictionaryEquippedData();
    }

    private void PopulateDictionaryEquippedData()
    {
        equippedData.Add(leftSocket, null);
        equippedData.Add(rightSocket, null);
    }

    public void Pickup(ItemData item)
    {
        Debug.Log("Pickup: " + item);
        items.Add(item);
    }

    public void Drop(ItemData data)
    {
        var go = Instantiate(items[0].DropItem, transform.position + transform.forward * 2 + transform.up, Quaternion.identity);
        RemoveFromInventory(data);
        //items.TrimExcess();
    }

    private void RemoveFromInventory(ItemData data)
    {
        items.Remove(data);
    }

    public void ToggleUIInventory()
    {
        if (uiInventory.gameObject.activeInHierarchy)
        {
            Debug.Log("Enabled");
            uiInventory.Close();
        }
        else 
        {
            Debug.Log("Disabled");
            uiInventory.Open(items);
        } 
    }

    public void EquipItem(ItemData objectToEquip)
    {
        Transform socket = SelectHand(objectToEquip);
        if (equippedData[socket] != null) 
        {
            Pickup(equippedData[socket]);
            Destroy(socket.GetChild(0).gameObject);
        }
        Instantiate(objectToEquip.EquipItem, socket, false);
        equippedData[socket] = objectToEquip;
        RemoveFromInventory(objectToEquip);
        uiInventory.PopulateItemsSection(items);
    }

    private Transform SelectHand(ItemData objectToEquip)
    {
        if (objectToEquip.Type == ItemEnums.ItemType.shield) return leftSocket;
        else return rightSocket;
    }
}
