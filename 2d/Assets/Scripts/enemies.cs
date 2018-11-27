using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemies : MonoBehaviour {
    public float speed;
    public float followDistance;
    public float retreatDistance;

    private Transform player;

    private Rigidbody2D rigidbody;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(transform.position, player.position) < followDistance)
        {
            rigidbody.velocity = new Vector2(player.position.x - transform.position.x, 0) * speed;

         
        }
        else
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
       
	}
    
}
