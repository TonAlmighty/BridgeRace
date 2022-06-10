using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
             CollectItems collectItem;
            if(other.TryGetComponent(out collectItem))
            {
                collectItem.AddNewItems(transform);
            }
           
        }
    }
}
