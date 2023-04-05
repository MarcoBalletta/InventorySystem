using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>();
    
    public void Pickup(ItemData item)
    {
        Debug.Log("Pickup: " + item);
        items.Add(item);
    }

    public void Drop(ItemData data)
    {
        var go = Instantiate(items[0].DropItem, transform.position + transform.forward * 2 + transform.up, Quaternion.identity);
        items.Remove(data);
        //items.TrimExcess();
    }
}
