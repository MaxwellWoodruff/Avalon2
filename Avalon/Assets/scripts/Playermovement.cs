using UnityEngine;
using System.Collections;
public class Playermovement : MonoBehaviour

{
   public Rigidbody2D rb;
   
   public float speed;

   public Animator animator;
   
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    animator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
       animator.SetFloat("speed", moveHorizontal*speed);
       if(Input.GetKeyDown(KeyCode.A))
       {
        Debug.Log("The A key was pressed");   
       }
       if(Input.GetKeyUp(KeyCode.S))
      {    
          Debug.Log("The S key was pressed");
      }
       if(Input.GetKeyDown(KeyCode.W))
       {  
        Debug.Log("The W key was pressed");   
       }
       if(Input.GetKeyDown(KeyCode.D))
       {  
        Debug.Log("The D key was pressed");   
       }
      float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");
      rb.velocity = new Vector2 (moveHorizontal*speed, moveVertical*speed);
    }     
}
