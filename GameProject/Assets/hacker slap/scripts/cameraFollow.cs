using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothing = 0.25f;
    // Update is called once per frame
    void Start()
    {
        transform.position = target.position + offset;
    }
    void FixedUpdate()
    {
        Vector3 desiredpos = target.position + offset;
        Vector3 smoothpos = Vector3.Lerp(transform.position, desiredpos, smoothing);
        transform.position = smoothpos;
        transform.LookAt(target);
    }
}
