using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStage : MonoBehaviour
{ 
    public bool checkStage = false;
    public static CheckStage ins;
    void Awake()
    {
        if (ins == null)
        {
            ins = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Constant.PLAYER_TAG))
        {
            checkStage = true;
        }
    }


}
