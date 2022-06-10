using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFireScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform playerTf;
    public int pooledAmount = 30;
    public float fireTime = .5f;
    List<GameObject> bullets;
    void Start()
    {
        bullets = new List<GameObject>(); 
        for(int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);
        }

        InvokeRepeating("Fire", fireTime, fireTime);
    }

    void Fire()
    {
        for(int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = playerTf.position;
                bullets[i].transform.rotation = playerTf.rotation;
                bullets[i].SetActive(true);
                break;
            }
        }
    }
}
