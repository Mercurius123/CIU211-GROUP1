//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerFlip : MonoBehaviour
//{
//    private Rigidbody2D theRB;

//    public float movespeed;

//    private float moveInput;
//    private bool facingRight = true;



//    void Start()
//    {

//    }

//    void Update()
//    {

//    }

//    void FixedUpdate()
//    {
//        moveInput = Input.GetAxis("Horizontal");
//        theRB.velocity = new Vector2(moveInput * movespeed, theRB.velocity.y);

//        if (facingRight == false && moveInput > 0)
//        {
//            Flip();
//        }
//        else if (facingRight == true && moveInput < 0)
//        {
//            Flip();
//        }



//    }


//    void Flip()
//    {
//        facingRight = !facingRight;
//        Vector3 Scaler = transform.localScale;
//        Scaler.x *= 1;
//        transform.localScale = Scaler;
//    }








//}