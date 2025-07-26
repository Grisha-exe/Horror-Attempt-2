using UnityEngine;

namespace InventorySystem
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private InventoryController _inventoryController;
        [SerializeField] private PlayerController _playerController;
            

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab)) _inventoryController.Switch();
            
            if (Input.GetKeyDown(KeyCode.LeftShift)) _playerController.SprintOn();
            
            if (Input.GetKeyUp(KeyCode.LeftShift)) _playerController.SprintOff();
            
            if (Input.GetKeyDown(KeyCode.E)) _inventoryController.PickUp();
        }
    }
}