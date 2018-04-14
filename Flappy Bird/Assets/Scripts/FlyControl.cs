using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyControl : MonoBehaviour {
    public Vector3 Birdmovement;
	public static FlyControl instance;
    //public Vector2 velocity = new Vector2(1,3);
    public Rigidbody2D Rb;
    public Animator anim;
	public GameObject gameover;
    bool dead = false;
	// Use this for initialization
	void Start () {
        anim = transform.GetComponentInChildren<Animator>();
        Birdmovement = transform.position;
    }
    public float jumpForce;
    void Update()
    {
        if(dead != true)
        { 
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            anim.SetTrigger("flapping");
                //Rb.AddForce(;
            Rb.velocity = new Vector2(0, jumpForce);
        }

        transform.position = new Vector3(transform.position.x , Mathf.Clamp(transform.position.y, -1.39f, 2.79f), 0);
        //if (transform.position.y < 0.36f)
        //{
        //        dead = true;
                
        //}
        }


    }
    void OnCollisionEnter2D(Collision2D coll)
    {
		score.instance.UpdateScore ();
        dead = true;
        anim.SetTrigger("die");
		gameover.SetActive (true);	
    }
}