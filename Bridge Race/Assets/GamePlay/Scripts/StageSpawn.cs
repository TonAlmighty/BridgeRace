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
        private Transform tf;

        private void Awake()
        {
            tf = transform;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Constant.PLAYER_TAG))
            {
                playerItem = other.gameObject.GetComponentInParent<CollectItems>();

                //TODO: cache  Componenet...

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
           
                var brickMove1 = Instantiate(brickMove, tf.position, tf.rotation);
                brickMove.transform.localScale = new Vector3(8, 1, 2.5f);
                brickMove1.transform.rotation = Quaternion.Euler(new Vector3(-20.9f, 0, 0));
                var stage = Instantiate(brickBridge, tf.position, tf.rotation);
            stage.GetComponent<MeshRenderer>().material.color = ChooseMaterial.SetColor(playerItem.brickType);

            //BrickBridge _brickBridge = stage.GetComponent<BrickBridge>();
            //if (_brickBridge != null) _brickBridge.SetColor(playerItem.brickType);

            Debug.Log(playerItem.brickType);
                Destroy(gameObject);

            if (CheckStage.ins.checkStage)
            {
                //Destroy(stage);
                //Destroy(brickMove1);


                stage.SetActive(false);
                brickMove1.SetActive(false);
            }
            
          
        }
    }
}
