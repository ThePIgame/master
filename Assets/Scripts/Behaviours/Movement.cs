using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour { 

    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        
        if (rb.velocity.magnitude > 0)      
            GetComponent<Animator>().SetBool("isWalking", true);
        else
            GetComponent<Animator>().SetBool("isWalking", false);

    }
    /*float xSpeed = 0f;
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

    bool isWalking;
    if (velocity.magnitude > 0) {
        isWalking = true;
    } else {
        isWalking = false;
    }
    GetComponent<Animator> ().SetBool ("isWalking", isWalking);

    transform.position += velocity;*/


}
