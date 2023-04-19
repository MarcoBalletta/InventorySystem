using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "InventoryObject/CreateItem", order = 0)]
public class ItemData : ScriptableObject
{
    [SerializeField] private string itemName;
    [SerializeField] private int id;
    [SerializeField] private float weight;
    [SerializeField] private float sellValue;
    [SerializeField] private Sprite icon;
    [SerializeField] protected ItemEnums.ItemType type;
    [SerializeField] private GameObject dropItem;

    public GameObject DropItem { get => dropItem; }
}
