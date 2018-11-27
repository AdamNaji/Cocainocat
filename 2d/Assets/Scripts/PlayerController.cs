using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1.0f;
    [SerializeField] private int maxAvailableJumps = 1;
    [SerializeField] private float moveForce = 1.0f;

    SpriteRenderer playerRenderer;

    private int jumpCounter = 0;
    private Rigidbody2D playerRigidbody2D;
    bool JumpKeyPressed = false;

    // private Collider2D[] contacts;

	void Start ()
	{
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponentInChildren<SpriteRenderer>();
        // contacts =new Collider2D[5];
	}

    void Update () {

        float moveX = Input.GetAxisRaw("Horizontal");
        playerRigidbody2D.AddForce(new Vector2(moveX, 0) * moveForce * Time.deltaTime);

        // Moving right.
        if (moveX > 0)
	    {
            playerRenderer.flipX = false;
	    }

        // Moving left.
        else if (moveX < 0)
        {
            playerRenderer.flipX = true;
        }

        // Jumping mechanics.
        if (Input.GetButtonDown("Jump") && jumpCounter < maxAvailableJumps)
	    {
            jumpCounter += 1;
            JumpKeyPressed = true;
	    }
	}
    // verfifier la collision 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Jump counter reset");
        jumpCounter = 0;
    }

    //permet de ne pas sauter durant le menu pause
    private void FixedUpdate()
    {
        if (JumpKeyPressed)
        {
            playerRigidbody2D.AddForce(Vector2.up * jumpForce);
            JumpKeyPressed = false;
        }
    }
}
