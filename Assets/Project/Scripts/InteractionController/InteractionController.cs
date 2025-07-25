using InventorySystem;
using Project.Scripts.Items;
using UnityEngine;
using UnityEngine.Serialization;

namespace Project.Scripts.InteractionController
{
    public class InteractionController : MonoBehaviour
    {
        [SerializeField] private float _rayLength = 5f;
        [SerializeField] private InventoryController _inventoryController;



        private void Update()
        {
            Vector3 screenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f);
            Ray ray = Camera.main.ScreenPointToRay(screenCenter);

            if (Physics.Raycast(ray, out RaycastHit hit, _rayLength))
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.green);

                if (hit.collider.GetComponent<ItemPickUpTrigger>())
                {
                    var index = hit.collider.GetComponent<ItemPickUpTrigger>().GetItemIndex();
                    _inventoryController.ShowPickupWindow(index);
                }
                else
                {
                    _inventoryController.HidePickupWindow();
                }
            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * _rayLength, Color.blue);
                _inventoryController.HidePickupWindow();
            }
        }
    }
}