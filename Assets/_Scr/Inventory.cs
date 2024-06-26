using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Resource> resources;
    [SerializeField] private List<Weapon> weapons;
    [SerializeField] private List<SO_ItemBlueprint> unlockedBlueprints;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ItemManager.Instance.OnCraftTable(resources[0]);
        }
    }
}
