using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Items;
using Unity.VisualScripting;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] private List<Item> _items;
    [SerializeField] private GameObject ItemHolder;
    [SerializeField] private ItemsDataList _itemsDataList;

    public void DeleteItemFromScene(string index)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (index == _items[i].Index)
            {
                Destroy(_items[i].gameObject);
                _items.RemoveAt(i);
            }
        }
    }

    public void AddItemToHands(string index)
    {
        for (int i = 0; i < _itemsDataList.items.Count; i++)
        {
            if (index == _itemsDataList.items[i].Index)
            {
                Instantiate(_itemsDataList.items[i].ModelPrefab, ItemHolder.transform).transform.rotation = ItemHolder.transform.rotation;
            }
            
        }
    }

    private void Awake()
    {
        _items = FindObjectsOfType<Item>().ToList();
    }
}
