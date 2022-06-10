using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform itemHolderTransform;
    public int numOfItemsHolding = 0;
    public List<GameObject> listItems;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewItems(Transform itemToAdd)
    {
        
        itemToAdd.SetParent(itemHolderTransform, true);

        itemToAdd.localPosition = new Vector3(0,1f*numOfItemsHolding,0);
        itemToAdd.localRotation = Quaternion.identity;
        numOfItemsHolding++;
    }
}
