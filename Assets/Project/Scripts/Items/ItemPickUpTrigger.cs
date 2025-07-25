using UnityEngine;

namespace Project.Scripts.Items
{
    public class ItemPickUpTrigger : MonoBehaviour
    {
        [SerializeField] private Item _item;

        public string GetItemIndex()
        {
            
            return _item.Index;
        }
    }
}