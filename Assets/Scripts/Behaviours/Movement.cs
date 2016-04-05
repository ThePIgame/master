using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour { 

    //private Rigidbody rb;

    private float horizontal;
    private float vertical;

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;

    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;

	private bool isWalking = false;

    void Awake()
    {
        //rb = GetComponent<Rigidbody>();
    }


    void Update()
	{
		CharacterController controller = GetComponent<CharacterController> ();

		if (controller.isGrounded) {
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection = moveDirection.normalized * speed;

			if (Input.GetButton ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

		isWalking = controller.velocity.magnitude > 0;
		GetComponent<Animator> ().SetBool ("isWalking", isWalking);

    }

}