using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    bool facingRight = true;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        float moveInputHorizontal = Input.GetAxisRaw("Horizontal");

        if(moveInputHorizontal < 0 && facingRight){
            flip();
        }
        if(moveInputHorizontal > 0 && !facingRight){
            flip();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
