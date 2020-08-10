using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctions : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    private Rigidbody2D theRB;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public bool isGrounded;


    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-movespeed, theRB.velocity.y);
        }

        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
        }

        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpforce);
        }



        
        
       
    }
}
