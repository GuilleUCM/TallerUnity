using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Animator anim;
	private bool facingRight;
	private bool jump = false;

	public float maxSpeed;
	public float jumpForce;
	public Transform groundCheck;
	public LayerMask groundLayerMask;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
		facingRight = false;
		Flip ();
	}

	void Update() {
		bool grounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayerMask.value);
		if(Input.GetButtonDown("Jump") && grounded)
			jump = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2(move*maxSpeed, rigidbody2D.velocity.y);
		anim.SetFloat("Speed",Mathf.Abs(move));
		if (move>0 && !facingRight)
			Flip();
		if (move<0 && facingRight)
			Flip();
		if (jump) {
			// Set the Jump animator trigger parameter.
			anim.SetTrigger("Jump");
			// Add a vertical force to the player.
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			
			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}
	}

	void Flip() {
		Vector3 v;
		if (facingRight)
			v = Vector3.Slerp(Vector3.right, Vector3.left, 1.0f);
		else
			v = Vector3.Slerp(Vector3.left, Vector3.right, 1.0f);
		facingRight = !facingRight;

		transform.rotation = Quaternion.LookRotation(v);
	}}
