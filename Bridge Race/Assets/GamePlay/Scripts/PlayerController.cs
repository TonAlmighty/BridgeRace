using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Player Controller")]
    private Rigidbody rb;
    public DynamicJoystick joystick;
    public Animator animator;
    public float moveSpeed;
    private Transform tf;
    public GameObject winPar;
    public LayerMask layerMask;
    public GameObject rayPos;
    public BrickType playerMatType;



    private void Awake()
    {
     
        rb = GetComponent<Rigidbody>();
        tf = transform;
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed,rb.velocity.y,joystick.Vertical*moveSpeed);
        if(joystick.Horizontal !=0 || joystick.Vertical != 0)
        {
           
            tf.rotation = Quaternion.LookRotation(rb.velocity);
            SoundManager.ins.PlayStepSound();
            animator.SetBool(Constant.ANIM_RUN, true);
            animator.SetBool(Constant.ANIM_IDLE, false);
        }
        else
        {
            animator.SetBool(Constant.ANIM_RUN, false);
            animator.SetBool(Constant.ANIM_IDLE, true);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Constant.FINISH))
        {
            winPar.SetActive(true);
            SoundManager.ins.PlayWinSound();
        }
    }



}
