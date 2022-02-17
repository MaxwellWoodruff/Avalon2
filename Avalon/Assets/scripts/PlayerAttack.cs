using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            Jumping();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Crouch();
        }
    }

    void Attack()
    {
    animator.SetTrigger("Attack");
    }

    void Jumping()
    {
        animator.SetTrigger("Jumping");
    }

    void Crouch()
    {
        animator.SetTrigger("Crouch");
    }
    void OnCollisionEnter2D(Collision2D coli)
    {
        if (coli.gameObject.tag =="Ground")
        {
            animator.SetTrigger("Grounded");
            Debug.Log("We hitting the ground");
        }
    } 
}
