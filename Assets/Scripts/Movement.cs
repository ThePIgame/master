using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed = 1f;

	void Update () {
		float xSpeed = 0f;
		float zSpeed = 0f;

		if (Input.GetKey (KeyCode.W)) {
			zSpeed = speed;
		} else if (Input.GetKey (KeyCode.S)) {
			zSpeed = -speed;
		}

		if (Input.GetKey (KeyCode.A)) {
			xSpeed = -speed;
		} else if (Input.GetKey (KeyCode.D)) {
			xSpeed = speed;
		}

		Vector3 velocity = new Vector3 (xSpeed, 0f, zSpeed).normalized * speed;

		transform.position += velocity;
	}

}
