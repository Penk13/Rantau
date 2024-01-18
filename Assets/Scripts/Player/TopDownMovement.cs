using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    bool facingRight = true;
    Animator anim;

    void Start()
    {
        // Get the Animator component attached to the same GameObject
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        float moveInputHorizontal = movement.x;

        if(moveInputHorizontal < 0 && facingRight){
            flip();
        }
        if(moveInputHorizontal > 0 && !facingRight){
            flip();
        }
        anim.SetFloat("Speed", Mathf.Abs(movement.x + movement.y));

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -12.0f, 75.0f),
            Mathf.Clamp(transform.position.y, -15.0f, 60.0f));
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
