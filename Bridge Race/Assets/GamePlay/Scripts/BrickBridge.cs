using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBridge : MonoBehaviour
{
    public BrickType brickType;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        SetColor();
    }
  

  
    public void SetColor()
    {
        meshRenderer.material.color = ChooseMaterial.SetColor(brickType);
    }
}
