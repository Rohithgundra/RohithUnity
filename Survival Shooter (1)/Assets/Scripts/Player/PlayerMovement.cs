using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
	public VirtualJoystick joystick;
    public LayerMask Floormask;
   	Vector3 movement;
   	Animator anim;
   	Rigidbody PlayerRB;
   	float camraylength = 100;
	public Rigidbody rigid;

   	void Awake ()
	{
		//floormask = LayerMask.GetMask("Floor");
		anim = GetComponent<Animator>();
		rigid = GetComponent<Rigidbody>();
		PlayerRB = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		Vector3 dir = Vector3.zero;
		if (joystick.InputDirection != Vector3.zero) 
		{
			dir = joystick.InputDirection;
			Move (dir.x, dir.z);
			Animating (dir.x, dir.z);
			Rotateplayer ();
		} 

		else 
		{
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");
			Move (h, v);
			Animating (h, v);
			Rotateplayer ();
		}
	}
	void Move (float h, float v)
	{
		movement.Set(h,0f,v);
		movement = movement.normalized*speed*Time.deltaTime;
		PlayerRB.MovePosition(movement+ transform.position);
	}

	void Rotateplayer ()
	{
		Ray Camray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit Floorhit;
		if (Physics.Raycast (Camray, out Floorhit, camraylength, Floormask)) {
			Vector3 mousepos = Floorhit.point - transform.position;
			mousepos.y = 0f;
			Quaternion newRotation = Quaternion.LookRotation (mousepos);
			PlayerRB.MoveRotation (newRotation);
		}
	}
	void Animating(float h, float v)
	{
		bool walking = h!=0f || v!=0f;
		anim.SetBool("IsWalking", walking);
	}
}
