using UnityEngine;

namespace InventorySystem
{
    public class ShowCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject _canvas;

        void Start()
        {
            Hide();
        }
        
        public void Show()
        {
            _canvas.SetActive(true);
        }

        public void Hide()
        {
            _canvas.SetActive(false);
        }
    }
}