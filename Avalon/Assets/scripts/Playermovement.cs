using UnityEngine;
using System.Collections;
public class Playermovement : MonoBehaviour

{
   public Rigidbody2D rb;
   public float speedX;
   public float speedY;
   
    void Start()
    {
        
     //Debug.Log("Hello,God");
       
        
    }

    
    void Update()
    {
      // Debug.Log("this is the start");
       if(Input.GetKeyDown(KeyCode.A))
       {
           transform.position = transform.position + 
            new Vector3(-1,0,0);
        Debug.Log("The A key was pressed");   
       }
       if(Input.GetKeyDown(KeyCode.S))
       {
            transform.position = transform.position + 
            new Vector3(0,-1,0);
           Debug.Log("The S key was pressed");
       }
       if(Input.GetKeyDown(KeyCode.W))
       {
           transform.position = transform.position + 
            new Vector3(0,1,0);
        Debug.Log("The W key was pressed");   
       }
       if(Input.GetKeyUp(KeyCode.D))
       {
           transform.position = transform.position + 
            new Vector3(1,0,0);
        Debug.Log("The D key was pressed");   
       }
    } 
}
