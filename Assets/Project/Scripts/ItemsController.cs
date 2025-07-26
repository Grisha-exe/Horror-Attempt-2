using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Items;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] private List<Item> _items;

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

    private void Awake()
    {
        _items = FindObjectsOfType<Item>().ToList();
    }
}
