using System;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts
{
    [Serializable]
    public class ItemData
    {
        public string Index;
        public string ItemName;
        [TextArea(1,10)]public string ItemDescription;
        public Sprite ItemIcon;
        public GameObject ModelPrefab;
    }
}