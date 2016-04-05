using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

	public GameObject objectToFollow;
	public Vector3 offset;

	public float speed = 1f;

	void Update () {
		Vector3 curPos = transform.position;
		Vector3 nextPos = objectToFollow.transform.position + offset;

		transform.position = Vector3.Lerp (curPos, nextPos, speed);
	}

}
