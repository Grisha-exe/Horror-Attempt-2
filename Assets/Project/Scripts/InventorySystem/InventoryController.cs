using UnityEngine;
using UnityEngine.Serialization;

namespace InventorySystem
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField] public GameObject InteractionPanel;
        [FormerlySerializedAs("Canvas")] [SerializeField] public GameObject InventoryOverlay;

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


        public void ShowPickupWindow()
        {
            if(IsPickupWindowOpen)
                return;
            
            IsPickupWindowOpen = true;
            
            InteractionPanel.SetActive(true);
        }

        public void HidePickupWindow()
        {
            if(!IsPickupWindowOpen)
                return;
            
            IsPickupWindowOpen = false;
            
            InteractionPanel.SetActive(false);
        }
    }
}