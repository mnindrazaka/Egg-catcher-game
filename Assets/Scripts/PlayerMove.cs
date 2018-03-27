using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	public float speed = 10;
	private bool flip = false;

	// Use this for initialization
	void Awake () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		MovePlayer (horizontal, vertical);
		FlipPlayer (horizontal);
	}

	void MovePlayer(float horizontal, float vertical) {
		myRigidBody.velocity = new Vector2 (horizontal * speed, vertical * speed);
	}

	void FlipPlayer(float horizontal) {
		if (horizontal > 0 && flip || horizontal < 0 && !flip) {
			flip = !flip;
			float flipScaleX = transform.localScale.x * -1;
			transform.localScale = new Vector3 (flipScaleX, transform.localScale.y);
		}
	}
}
