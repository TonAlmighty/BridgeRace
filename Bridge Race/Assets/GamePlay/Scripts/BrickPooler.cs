using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPooler : MonoBehaviour
{
    public int row, col; 
   public Vector3 initPos;
   public float distanceX = -5f;
   public float distanceY = 6f;

    public List<string> mats = new List<string> {"red","blue","yellow" };
    // Start is called before the first frame update
    void Start()
    {

        InitBrick();
    }


    private void InitBrick()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                //Debug.Log("alo");
                Vector3 pos = Vector3.zero;
                float x = initPos.x + j * distanceX;
                float y = initPos.z + i * distanceY;
                pos.x = x;
                pos.z = y;
                pos.y = 0.5f;
                GameObject brick = (GameObject)ObjectPooler.SharedInstance.GetPooledObject(GetColor());
                //Debug.Log(brick);
                brick.transform.position = pos;
                brick.SetActive(true);
            }

        }
    }

   public string GetColor()
    {
        int mat = Random.Range(0, 3);
        Debug.Log(mat);
        if (mat == 0)
        {
            return "red";
        }else if(mat == 1)
        {
            return "blue";
        }
        else 
        {
            return "yellow";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
