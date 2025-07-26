using Project.Scripts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace InventorySystem
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField] private ItemsDataList _itemDataList;
        [SerializeField] public InteractionPanel InteractionPanel;
        [SerializeField] private ItemsController _itemsController;

        [FormerlySerializedAs("Canvas")] [SerializeField]
        public GameObject InventoryOverlay;

        private string _currentItemIndex;

        public bool IsOpened = true;
        private bool IsPickupWindowOpen = true;

        private void Start()
        {
            Hide();
            HidePickupWindow();
        }

        public void Switch()
        {
            if (IsOpened)
                Hide();
            else
                Show();
        }

        public void Show()
        {
            InventoryOverlay.SetActive(true);
            IsOpened = true;
        }

        public void Hide()
        {
            InventoryOverlay.SetActive(false);
            IsOpened = false;
        }


        public void ShowPickupWindow(string index)
        {
            if (IsPickupWindowOpen)
                return;

            IsPickupWindowOpen = true;

            InteractionPanel.gameObject.SetActive(true);

            for (int i = 0; i < _itemDataList.items.Count; i++)
            {
                if (_itemDataList.items[i].Index == index)
                {
                    InteractionPanel.SetData(_itemDataList.items[i].ItemIcon, _itemDataList.items[i].ItemName);
                    _currentItemIndex = index;
                }
            }
        }

        public void HidePickupWindow()
        {
            if (!IsPickupWindowOpen)
                return;

            IsPickupWindowOpen = false;

            InteractionPanel.gameObject.SetActive(false);
        }

        public void PickUp()
        {
            if (IsPickupWindowOpen)
            {
                var item = _itemDataList.GetItemDataById(_currentItemIndex);
                _itemsController.DeleteItemFromScene(_currentItemIndex);
                _itemsController.AddItemToHands(_currentItemIndex);


            }
        }
    }
}