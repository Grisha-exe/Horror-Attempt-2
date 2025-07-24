using UnityEngine;

namespace InventorySystem
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private InventoryController _inventoryController;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab)) _inventoryController.Switch();
        }
    }
}