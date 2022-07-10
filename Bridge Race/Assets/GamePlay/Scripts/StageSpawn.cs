using UnityEngine;

namespace BridgeRace
{
    public class StageSpawn : MonoBehaviour
    {
        [SerializeField]
        private GameObject brickBridge;
        [SerializeField]
        private GameObject brickMove;
        private CollectItems playerItem;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Constant.PLAYER_TAG))
            {
                playerItem = other.gameObject.GetComponentInParent<CollectItems>();

                if (playerItem.numOfItemsHolding > 0)
                {
                    Debug.Log(playerItem.numOfItemsHolding);
                    playerItem.RemoveBrick();
                    Spawn();
                }
            }
        }

        private void Spawn()
        {
           
                var brickMove1 = Instantiate(brickMove, transform.position, transform.rotation);
                brickMove.transform.localScale = new Vector3(8, 1, 2.5f);
                brickMove1.transform.rotation = Quaternion.Euler(new Vector3(-20.9f, 0, 0));
                var stage = Instantiate(brickBridge, transform.position, transform.rotation);
                stage.GetComponent<MeshRenderer>().material.color = ChooseMaterial.SetColor(playerItem.brickType);

                Debug.Log(playerItem.brickType);
                Destroy(gameObject);

            if (CheckStage.ins.checkStage)
            {
                Destroy(stage);
                Destroy(brickMove1);
            }
            
          
        }
    }
}
