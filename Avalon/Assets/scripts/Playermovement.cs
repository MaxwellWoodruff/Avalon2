using UnityEngine;
using System.Collections;
public class Playermovement : MonoBehaviour

{
   public Rigidbody2D rb;

   public float speed;

   public Animator animator;
   
   public float moveHorizontal;

   public float attackrecovery;
   
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    animator = gameObject.GetComponent<Animator>();
    attackrecovery=0;
    }

    
    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");
        if(attackrecovery>0)
      {
        attackrecovery--;
        moveHorizontal=0;
      }
      rb.velocity = new Vector2 (moveHorizontal*speed, moveVertical*speed);
        if(Input.GetKeyUp(KeyCode.T))
       {  
        Debug.Log("Attacking");
       attackrecovery = 91;  
       }
       animator.SetFloat("speed",Mathf.Abs (moveHorizontal*speed));
       if(Input.GetKeyDown(KeyCode.A))
       {
        Debug.Log("Running to right"); 
       }
       if(Input.GetKeyUp(KeyCode.S))
      {    
       //   Debug.Log("Crouching");
      }
       if(Input.GetKeyDown(KeyCode.W))
       {  
        //Debug.Log("Jumping");   
       }
       if(Input.GetKeyDown(KeyCode.D))
       {  
        Debug.Log("Righting to the left");   
       }
    }     
}
