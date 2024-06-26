using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SO/SO_Blueprint")]
public class SO_ItemBlueprint : ScriptableObject
{
    [SerializeField] private List<Item> list;
    public List<Item> GetList => list;
}
