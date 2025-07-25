using UnityEngine;
using UnityEngine.Serialization;

namespace InventorySystem
{
    public class InventoryController : MonoBehaviour
    {
        [FormerlySerializedAs("Canvas")] [SerializeField] public GameObject InventoryOverlay;

        public bool IsOpened = true;
        private bool IsPickupWindowOpen = false;

        private void Start()
        {
            Hide();
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
            
            Debug.Log("Pickup Window Show");
        }
        
        public void HidePickupWindow()
        {
            if(!IsPickupWindowOpen)
                return;
            
            IsPickupWindowOpen = false;
            
            Debug.Log("Pickup Window Hide");
        }
    }
}