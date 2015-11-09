using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float velocity = 2f;

	public KeyCode keyup;
	public KeyCode keydown;

	private bool movingUp;
	private bool movingDown;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(keyup)) {
			movingUp = true;
		} else {
			movingUp = false;
		}

		if (Input.GetKey(keydown)) {
			movingDown = true;
		} else {
			movingDown = false;
		}
	}

	void FixedUpdate() {

		if (movingUp) {
			rb.velocity = new Vector2(0f, velocity);
		} else if (movingDown) {
			rb.velocity = new Vector2(0f, -velocity);
		} else {
			rb.velocity = Vector2.zero;
		}

	}

}
