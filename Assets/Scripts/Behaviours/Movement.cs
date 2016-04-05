using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
    //private Rigidbody rb;
	private CharacterController controller;
	private Animator animator;

    private float horizontal;
    private float vertical;

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;

    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;

    void Awake()
    {
        //rb = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();
    }


	void Update()
	{
		if (controller.isGrounded) {
			horizontal = Input.GetAxis ("Horizontal");
			vertical = Input.GetAxis ("Vertical");

			moveDirection = new Vector3 (horizontal, 0, vertical);
			//moveDirection = transform.TransformDirection (moveDirection);
			moveDirection = moveDirection.normalized * speed;

			if (moveDirection.magnitude > 0) {
				animator.SetBool ("isWalking", true);
			} else {
				animator.SetBool ("isWalking", false);
			}

			if (Input.GetButton ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

	}

}