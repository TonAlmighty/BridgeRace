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

    public BrickType playerMatType;



    private void Awake()
    {
     
        rb = GetComponent<Rigidbody>();
        tf = transform;
       
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed,rb.velocity.y,joystick.Vertical*moveSpeed);
        if(joystick.Horizontal !=0 || joystick.Vertical != 0)
        {
           
            tf.rotation = Quaternion.LookRotation(rb.velocity);
            animator.SetBool(Constant.ANIM_RUN, true);
            animator.SetBool(Constant.ANIM_IDLE, false);
        }
        else
        {
            animator.SetBool(Constant.ANIM_RUN, false);
            animator.SetBool(Constant.ANIM_IDLE, true);
        }
        
    }

   
   

}
