using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looper : MonoBehaviour {
    public GameObject StartPosition, EndPosition, controlobject,pipes;

    //public static void Ignorecollision(Collider2D Centerposition, );
    //public Vector3 pipeins;
    private void Start()
    {

    }
    public void Insta(Vector3 EndPosi)
    {
        //  Vector3 pos = EndPosition.transform.position;
        Debug.Log("Instanciate");
        Instantiate(controlobject,EndPosi, Quaternion.identity);
        //Instantiate(pipes, EndPosi, Quaternion.identity);
        if(Time.fixedTime > 8)
        {
            Destroy(GameObject.Find("BGprefab(Clone)"), 4f);
            Destroy(GameObject.Find("pipe(Clone)"), 4f);
        //  transform.position = pos;
        }
    }
    public void pipeloop(Vector3 pipelocation)
    {
       // pipelocation =transform.position;
        pipelocation.y += 2.74f;
       // transform.position = pipelocation;
       Instantiate(pipes, pipelocation, Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("collided");
        if(coll.gameObject.name == "Start Position")
        {
            Insta(coll.GetComponent<Posdecide>().Endpos);
            pipeloop(coll.GetComponent<Posdecide>().Endpos);
            //if(Time.unscaledTime > 2)
            //Destroy (GameObject.Find("BGprefab(Clone)"), 2.5f);
        }
        
    }

}