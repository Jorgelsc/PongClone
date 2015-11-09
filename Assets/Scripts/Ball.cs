using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Rigidbody2D rb;

	int playerIdx = 0;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody2D>();

		rb.AddForce(new Vector2(0.05f, 0.05f));

	}

	void setInitialPosition () {

		gameObject.transform.position = Vector3.zero;
		rb.velocity = Vector2.zero;

		Invoke("restartBall", 1f);

	}

	void restartBall () {

		if (playerIdx == 1) {
			rb.AddForce(new Vector2(Random.Range(0.04f, 0.07f), Random.Range(-0.04f, 0.07f)));
		} else if (playerIdx == 2) {
			rb.AddForce(new Vector2(Random.Range(-0.04f, -0.07f), Random.Range(-0.04f, 0.07f)));
		}

	}

	void OnCollisionEnter2D (Collision2D other) {

		if (other.gameObject.tag == "Player") {
			rb.velocity = rb.velocity + other.gameObject.GetComponent<Rigidbody2D>().velocity / 2;
		}

		if (other.gameObject.tag == "WallLeft") {
			ScoreManager.instance.incrementScore(2);
			playerIdx = 2;
			setInitialPosition();
		}

		if (other.gameObject.tag == "WallRight") {
			ScoreManager.instance.incrementScore(1);
			playerIdx = 1;
			setInitialPosition();
		}

	}

}
