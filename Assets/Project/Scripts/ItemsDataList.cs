using System.Collections.Generic;
using Project.Scripts;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemDataList", menuName = "Data/Item")]
public class ItemsDataList : ScriptableObject
{
    public List<ItemData> items = new List<ItemData>();
}