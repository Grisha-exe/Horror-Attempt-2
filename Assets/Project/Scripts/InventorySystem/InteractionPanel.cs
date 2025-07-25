using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class InteractionPanel : MonoBehaviour

    {
        [SerializeField] private Image _itemIcon;
        [SerializeField] private TMP_Text _itemName;

        public void SetData(Sprite itemIcon, string itemName)
        {
            _itemIcon.sprite = itemIcon;
            _itemName.text = itemName;
        }
    }
}