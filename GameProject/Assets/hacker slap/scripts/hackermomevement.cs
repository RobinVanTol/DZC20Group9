using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackermomevement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D hacker;
    public Animator animator;
    public Vector2 movement;
    public Transform player;
    bool slapped;

    void Start()
    {
        slapped = false;
    }
    void Update()
    {
        transform.LookAt(player);
        movement = (transform.forward * moveSpeed * Time.deltaTime).normalized;
        transform.eulerAngles = new Vector3(0, 0, 0);
        if (!slapped)
        {
            animator.SetFloat("horizontal", movement.x / 2);
            animator.SetFloat("vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
            if (movement.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    void FixedUpdate()
    {
        hacker.MovePosition(hacker.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
