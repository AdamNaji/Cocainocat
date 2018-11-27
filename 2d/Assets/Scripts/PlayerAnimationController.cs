using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {

    private Animator playerAnimator;

	// Use this for initialization
	void Start () {
        playerAnimator = gameObject.GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0 || Input.GetAxisRaw("Horizontal") > 0)
        {
            playerAnimator.SetBool("isMoving", true);
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            playerAnimator.SetBool("isMoving", false);
        }
    }
}
