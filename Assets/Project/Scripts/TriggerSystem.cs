using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    public GameObject GameObject;
    public GameObject Trigger;
    public bool IsTriggered = true;
    public Transform HoldPoint;
    private GameObject _objectToTrigger;

    private void Start()
    {
        IsTriggered = false;
    }

    public void PickUp(GameObject obj)
    {
        _objectToTrigger = obj;
        obj.transform.SetParent(HoldPoint);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localRotation = Quaternion.identity;
        
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log ("Игрок вошел в зону триггера!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок вышел из зоны триггера!");
        }
    }
    
    
}
