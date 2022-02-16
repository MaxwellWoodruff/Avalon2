using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Jumping();
        if(Input.GetKeyDown(KeyCode.S))
        {
            crouch();
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
        void crouch()
        {
            animator.SetTrigger("crouch");
        }
    }
}