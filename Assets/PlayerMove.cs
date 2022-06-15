using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector3 move;
    public bool interaction;
    public static int scenenum;

    void Start()
    {
        //Interactions interaction = movement.GetComponent<Interactions>(inter);
        //interaction.inter = true;
        scenenum = 0;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
  
    // Update is called once per frame
    void Update()
    {
        interaction = Interactions.inter;
        if (!interaction)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                speed = 7f;
            else
                speed = 4f;
            move = Vector3.zero;
            move.x = Input.GetAxisRaw("Horizontal");
            move.y = Input.GetAxisRaw("Vertical");
            AnimMove();
        }      
    }
    void AnimMove()
    {
        if (move != Vector3.zero)
        {
            Move();
            animator.SetFloat("Horizontal", move.x);
            animator.SetFloat("Vertical", move.y);
            animator.SetFloat("Speed", move.sqrMagnitude);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetFloat("Speed", 0);
            animator.SetBool("moving", false);
        }
    }

    void Move()
    {
        rb.MovePosition(transform.position + move * speed * Time.fixedDeltaTime);
    }
}
