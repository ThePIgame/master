using UnityEngine;
using System.Collections;

public class ShootObject : MonoBehaviour {
	
	public GameObject projectile;
	public float bulletSpeed = 1f;

	public float shootTime = 0.2f;
	private float lastShootTime = 0;

	public int numBullets = 12;
	private int curNumBullets = 12;

	public float reloadTime = 3f;
	private float reloadTimeCounter = 0;
	private bool reloading = false;

	void Update () {
		if (Input.GetMouseButton (0)) {
			if (!reloading) {
				if (curNumBullets > 0) {
					float timePassed = Time.time - lastShootTime;

					if (timePassed >= shootTime) {
						GameObject newProjectile = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
						newProjectile.GetComponent<Rigidbody> ().AddForce (transform.forward * bulletSpeed);

						lastShootTime = Time.time;
						curNumBullets--;
<<<<<<< HEAD

						Debug.Log ("Ammo: " + curNumBullets + " / " + numBullets);
=======
>>>>>>> ea558f288e87de0d02805128712312d48a724ec4
					}
				} else {
					reloading = true;
					reloadTimeCounter = Time.time;

					Debug.Log ("Reloading...");
				}
			}
		}

		if (reloading) {
			float timePassed = Time.time - reloadTimeCounter;

			if (timePassed >= reloadTime) {
				reloading = false;
				curNumBullets = numBullets;
<<<<<<< HEAD

				Debug.Log ("Ammo: " + numBullets + " / " + numBullets);
=======
>>>>>>> ea558f288e87de0d02805128712312d48a724ec4
			}
		}
	}
}
