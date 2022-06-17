using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPooler : MonoBehaviour
{
    
   public Vector3 initPos;
   public float distanceX = -3f;
   public float distanceY = 1f;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                //Debug.Log("alo");
                Vector3 pos = Vector3.zero;
                float x = initPos.x + j * distanceX;
                float y = initPos.z + i * distanceY;
                pos.x = x;
                pos.z = y;
                pos.y = 0.5f;
                GameObject brick = (GameObject)ObjectPooler.SharedInstance.GetPooledObject();

                Debug.Log(brick);

                brick.transform.position = new Vector3(1, 1, 1);
                brick.SetActive(true);
            }

        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
