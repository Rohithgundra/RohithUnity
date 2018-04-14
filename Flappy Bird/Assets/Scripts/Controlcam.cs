using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlcam : MonoBehaviour
{
    Transform player;
    float offsetx;
    // Use this for initialization
    void Start()
    {
        GameObject player_go = GameObject.Find("Birds");
        if (player_go == null)
        {
            Debug.LogError("couldn't find a gamobject with the tag player");
            return;
        }
        player = player_go.transform;
        offsetx = transform.position.x - player.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        if (player != null)
        {
            Vector3 campos = transform.position;
            campos.x = player.position.x + offsetx;
            transform.position = campos;
        }


    }
}