using UnityEngine;

namespace BridgeRace
{
    public class StageSpawn : MonoBehaviour
    {
        [SerializeField]
        private GameObject brickBridge;

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

            var stage = Instantiate(brickBridge, transform.position, transform.rotation);
            stage.GetComponent<MeshRenderer>().material.color = ChooseMaterial.SetColor(playerItem.brickType);

            Debug.Log(playerItem.brickType);
            Destroy(gameObject);
        }
    }
}
