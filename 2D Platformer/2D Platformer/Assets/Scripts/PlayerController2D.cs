using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;
    private bool isFacingRight = true;

    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); // Define what is Ground

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // If the player is moving right but facing left flip the player right
        if (!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }
        // If the player is moving left but facing right flip the player left
        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();            
        }
    }

    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce; // Makes the player jump
            doubleJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;

        //Vector3 scaler = transform.localScale; //Local variable that stores localscale value
        //scaler.x *= -1; // flip the sprite graphic
        //transform.localScale = scaler;
        transform.Rotate(0f, 180f, 0f);
        
    }
}
