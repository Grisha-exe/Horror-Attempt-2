using UnityEngine;
using UnityEngine.Serialization;

namespace InventorySystem
{
    public class InventoryController : MonoBehaviour
    {
        [FormerlySerializedAs("Canvas")] [SerializeField] public GameObject InventoryOverlay;

        public bool IsOpened = true;

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
    }
}