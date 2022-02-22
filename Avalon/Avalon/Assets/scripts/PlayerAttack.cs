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
       
	    if(Input.GetKeyDown(KeyCode.S))
		{
			Crouching();
		}		
		if(Input.GetKeyDown(KeyCode.W))
		{
			Jumping();
		}
    }

    void Attack()
    {
      animator.SetTrigger("Attack");
    }
	void Crouching()
	{
		animator.SetTrigger("Crouching");
	}
	void Jumping()
	{
		animator.SetTrigger("Jumping");
	}
}
