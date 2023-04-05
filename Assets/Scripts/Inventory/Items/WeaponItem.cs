using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponItem", menuName = "InventoryObject/CreateWeaponItem", order = 1)]
public class WeaponItem : ItemData
{
    protected readonly new ItemEnums.ItemType type = ItemEnums.ItemType.weapon;
    public ItemEnums.WeaponType weaponType;
    public float damage;

    
}
