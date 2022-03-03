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
       
	    if(Input.GetKeyDown(KeyCode.S))
		{
			animator.SetBool("Crouching",true);
			Debug.Log("Crouching");
		}		
		if(Input.GetKeyUp(KeyCode.S))
		{
			animator.SetBool("Crouching",false);
			Debug.Log("Standing");
		}
		if(Input.GetKeyDown(KeyCode.W))
		{
			animator.SetTrigger("Jumping");
			Debug.Log("In Air");
		}
		else
		{
			animator.SetBool("Jumping",false);
			Debug.Log("On Ground");
		}
    }

    void Attack()
    {
      animator.SetTrigger("Attack");
    }
}
