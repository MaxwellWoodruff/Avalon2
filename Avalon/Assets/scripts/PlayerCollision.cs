using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
public Rigidbody2D rb;
public float coli;
public Animator animator;
public bool Grounded = true;
 void Start()
 {
     rb = GetComponent<Rigidbody2D>();
     animator= GetComponent<Animator>();
 }
}
