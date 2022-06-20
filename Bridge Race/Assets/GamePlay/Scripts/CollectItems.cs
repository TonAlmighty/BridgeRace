using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform itemHolderTransform;
    public int numOfItemsHolding = 0;
    public List<GameObject> listItems;
    public string tagBrick="";
    private Vector3 oldPos;
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

        itemToAdd.localPosition = new Vector3(0,0.4f*numOfItemsHolding,0);
        itemToAdd.localRotation = Quaternion.identity;
        numOfItemsHolding++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagBrick))
        {
             oldPos = other.gameObject.transform.position;

            //StartCoroutine(RespawnBrick());
           
            CollectItems collectItem;
            if (gameObject.TryGetComponent(out collectItem))
            {
                collectItem.AddNewItems(other.transform);
            }

        }
    }

    IEnumerator RespawnBrick()
    {
        yield return new WaitForSeconds(3f);
        GameObject brick = (GameObject)ObjectPooler.SharedInstance.GetPooledObject(tagBrick);
        brick.transform.position = oldPos;
        brick.SetActive(true);
    }

}
