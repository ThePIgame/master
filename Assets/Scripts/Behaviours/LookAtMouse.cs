using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	public float rotationSpeed = 1f;

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			Vector3 lookAtPoint = hit.point;
			lookAtPoint.y = transform.position.y;

			Quaternion prevRotation = transform.rotation;
			transform.LookAt (lookAtPoint);
			Quaternion newRotation = transform.rotation;

			transform.rotation = Quaternion.Lerp (prevRotation, newRotation, rotationSpeed);
		}
	}

}
