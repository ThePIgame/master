using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {
	
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			Vector3 lookAtPoint = hit.point;
			lookAtPoint.y = transform.position.y;

			transform.LookAt (lookAtPoint);
		}
	}

}
