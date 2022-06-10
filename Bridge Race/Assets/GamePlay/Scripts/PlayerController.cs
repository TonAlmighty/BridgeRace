using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public DynamicJoystick joystick;
    public Animator animator;
    public float moveSpeed;
    private Transform tf;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        tf = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed,rb.velocity.y,joystick.Vertical*moveSpeed);
        if(joystick.Horizontal !=0 || joystick.Vertical != 0)
        {
            tf.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }
}
