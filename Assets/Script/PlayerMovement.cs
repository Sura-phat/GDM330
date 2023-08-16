using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
        
    Vector2 movement;

    public Rigidbody2D rb;
    
    
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    

}
