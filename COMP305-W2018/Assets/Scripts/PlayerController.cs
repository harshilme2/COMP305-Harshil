using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxSpeed = 10.0f;
    public float jumpForce = 300.0f;
    public Transform gCheck;
    public LayerMask dGround;
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    private Animator animator;
    private bool isGrounded = false;
    private float groundRadius = 0.2f;


    void Start () {

        rBody = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetAxis("Jump") > 0 && isGrounded)
        {
            animator.SetBool("Ground", isGrounded);
            rBody.AddForce(new Vector2(0, jumpForce));
        }
    }

    void FixedUpdate () {

        //parameters for jump
        isGrounded = Physics2D.OverlapCircle(gCheck.position, groundRadius, dGround);
        animator.SetBool("Ground", isGrounded);
        animator.SetFloat("vSpeed", rBody.velocity.y);


        float moveHoriz = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(moveHoriz));

        rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

        if(moveHoriz > 0)
        {
            sRend.flipX = false;
        } else if (moveHoriz < 0)
        {
            sRend.flipX = true;
        }

	}
}
