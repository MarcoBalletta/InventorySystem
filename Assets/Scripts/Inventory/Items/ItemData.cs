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
    [SerializeField] private ItemEnums.ItemType type;
    [SerializeField] private GameObject dropItem;
    [SerializeField] private GameObject equipItem;

    //public ItemData( string name, float sellValue)
    //{
    //    itemName =
    //}

    public GameObject DropItem { get => dropItem; }
    public Sprite Icon { get => icon; }
    public float SellValue { get => sellValue; }
    public ItemEnums.ItemType Type { get => type; }
    public GameObject EquipItem { get => equipItem;}
}
