using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playable : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpforce = 1.0f;
    public int jumpcount = 1;

    private int currentjumpcount = 0;
    private Rigidbody2D body;
    private Collider2D[] contacts;
  

	// Use this for initialization
	void Start ()
	{
	    this.body = this.GetComponent<Rigidbody2D>();
        this.contacts =new Collider2D[5];
	}
	
	// Update is called once per frame
	void Update () {
        
        // move left
		if (Input.GetKey(KeyCode.LeftArrow))
	    {
            this.transform.Translate(Vector3.left * this.speed);
	    }


        //move right
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
            this.transform.Translate(Vector3.right * this.speed);
	    }


        //jump
        

	    if (Input.GetKeyDown(KeyCode.UpArrow))
	    {
	        if (this.currentjumpcount > 0 && this.GetComponent<Rigidbody2D>().GetContacts(contacts) > 0)
	        {
	            this.currentjumpcount = 0;
	        }
            if (this.currentjumpcount < this.jumpcount)
            {
	            this.currentjumpcount += 1;
	            body.AddForce(Vector2.up * this.jumpforce);
	        }
	    }
	}
}
