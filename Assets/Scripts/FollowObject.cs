using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

	public GameObject objectToFollow;
	public Vector3 offset;

	void Update () {
		transform.position = objectToFollow.transform.position + offset;
	}

}
