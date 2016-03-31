using UnityEngine;
using System.Collections;

public class ShootObject : MonoBehaviour {

	public GameObject projectile;
	public float speed = 1f;

	void Update () {
		if (Input.GetMouseButton (0)) {
			GameObject newProjectile = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
			newProjectile.GetComponent<Rigidbody> ().AddForce (transform.forward * speed);
		}
	}
}
