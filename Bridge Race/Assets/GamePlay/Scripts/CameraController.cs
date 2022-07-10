using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    private Transform tf;

    public Vector3 Offset;
    [SerializeField]
    private Vector3 velocity = Vector3.zero;

    public float SmoothTime = 0.3f;

    void Start()
    {
        tf = transform;
        //Offset = tf.position - target.position;
        Offset = new Vector3(0.33f, 13.5f, -14.7f);
    }

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + Offset;
        targetPosition = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
        tf.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
    }
}