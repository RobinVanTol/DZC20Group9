using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackermomevement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D hacker;
    public Animator animator;
    public Vector2 movement;
    public Vector2 slapdestination;
    public Transform player;
    public Transform target;
    public bool slapped;
    public bool firstslap;
    public float dist;
    public float slapdist;
    void Start()
    {
        slapped = false;
        firstslap = true;
    }
    void Update()
    {
        if (!slapped)
        {
            transform.LookAt(target);
            movement = (transform.forward * moveSpeed * Time.deltaTime).normalized;
            transform.eulerAngles = new Vector3(0, 0, 0);
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
        else
        {
            if (firstslap)
            {
                transform.LookAt(player);
                slapdestination = transform.position + (-transform.forward).normalized*5;
                firstslap = false;
            }
            transform.LookAt(slapdestination);
            movement = (transform.forward * moveSpeed * Time.deltaTime).normalized;
            transform.LookAt(player);
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
    }

    void FixedUpdate()
    {
        hacker.MovePosition(hacker.position + movement * moveSpeed * Time.fixedDeltaTime);
        dist = Vector3.Distance(player.position, transform.position);
        slapdist = Vector3.Distance(slapdestination, transform.position);
        if (slapdist < 0.1 && slapped)
        {
            slapped = false;
            firstslap = true;
        }
        if (dist < 1.5 && !slapped)
        {
            slapped = true;
        }
    }
}
