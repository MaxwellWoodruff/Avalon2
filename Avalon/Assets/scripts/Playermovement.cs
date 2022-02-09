using UnityEngine;
using System.Collections;
public class Playermovement : MonoBehaviour

{
   //public Rigidbody2D rb;
   //public float speedX;
   //public float speedY;
   public Vector2 speed = new Vector2(50,50);
   
    void Start()
    {
        
     //Debug.Log("Hello,God");
       
        
    }

    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(speed.x*inputX, speed.y*inputY,0);
        movement*= Time.deltaTime;
        transform.Translate(movement);
      // Debug.Log("this is the start");
      // if(Input.GetKeyDown(KeyCode.A))
     // {
      //     transform.position = transform.position + 
       //     new Vector3(-1,0,0);
      //  Debug.Log("The A key was pressed");   
      // }
      // if(Input.GetKeyDown(KeyCode.S))
       //{
       //     transform.position = transform.position + 
       //     new Vector3(0,-1,0);
       //    Debug.Log("The S key was pressed");
      // }
      // if(Input.GetKeyDown(KeyCode.W))
      // {
      //     transform.position = transform.position + 
       //     new Vector3(0,1,0);
      //  Debug.Log("The W key was pressed");   
     //  }
       //if(Input.GetKeyUp(KeyCode.D))
      // {
      //     transform.position = transform.position + 
       //     new Vector3(1,0,0);
       // Debug.Log("The D key was pressed");   
      // }
    } 
}
