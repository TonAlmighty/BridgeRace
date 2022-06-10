using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("Destroy", 2f);
    }
    private void Destroy()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 20*Time.deltaTime); 
    }
}
