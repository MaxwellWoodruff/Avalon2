using UnityEngine;

public class Playermovement : MonoBehaviour

{
   //public Rigidbody2D rb;
   public float speedX;
   public float speedY;
    void Start()
    {
        
     Debug.Log("Hello,God");
       
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
        
            Debug.Log("A key was pressed");
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A key was released");
        }
    }
}