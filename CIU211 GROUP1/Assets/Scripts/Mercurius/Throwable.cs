using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public float ballSpeed;
    [Space]
    private Rigidbody2D theRB;

    public GameObject throwableEffect;



    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        theRB.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player1")
        {
            FindObjectOfType<SystemManager>().HurtP1();
          
        }

        if (other.tag == "Player2")
        {
            FindObjectOfType<SystemManager>().HurtP2();

        }


        Instantiate(throwableEffect, transform.position, transform.rotation);


        Destroy(gameObject);
    }
}
