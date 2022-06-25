using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBridge : MonoBehaviour
{
    public BrickType brickType;
    // Start is called before the first frame update
    void Start()
    {
        SetColor();
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetColor()
    {
        GetComponent<MeshRenderer>().material.color = ChooseMaterial.SetColor(brickType);
    }
}
