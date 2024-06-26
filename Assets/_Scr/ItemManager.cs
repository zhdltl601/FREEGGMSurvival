using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoSingleton<ItemManager>
{
    [SerializeField] private List<Item> itemsOnTable;
    public void OnCraftTable(Item item)
    {
        itemsOnTable.Add(item);
    }
    //public Item CraftItem()
    //{
    //    return new Weapon();
    //}
}
