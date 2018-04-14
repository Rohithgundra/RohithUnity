using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdfly : MonoBehaviour {
    Vector3 velocity = Vector3.zero;
    bool birdflap = false;
    public Vector3 flapvelocity;
    public Vector3 gravity;
    public float fwdspeed = 1f;
    public float flymax = 5f;
	// Use this for initialization.
	void Start () {
		
	}
    // Use this for graphic & input updates.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            birdflap = true;
        }
    }
    // Use this for physics engine updates. 
    void FixedUpdate () {
        velocity.x = fwdspeed;
        velocity += gravity * Time.deltaTime;
        if (birdflap == true)
            {
                birdflap = false;
                velocity += flapvelocity;
            }
            velocity = Vector3.ClampMagnitude(velocity, flymax);
        transform.position += velocity * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, .68f, 8f), 0);
	}
}