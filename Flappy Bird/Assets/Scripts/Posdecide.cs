using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posdecide : MonoBehaviour {
    // Use this for initialization
    public GameObject Startpos;
    public Vector3 Endpos;
    void Start() {
        Endpos = Startpos.transform.position;
        //Vector3 Startposit = EndPosition.transform.position;
        //float dist= Endpos.x - Startposit.x;
        Endpos.x += 9.4f;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
