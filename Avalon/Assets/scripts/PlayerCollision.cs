using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
public float dumbass;


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("we hit");
    }
    
    
}
