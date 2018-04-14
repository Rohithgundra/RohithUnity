using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class SimpleAds : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Advertisement.Initialize ("1761618");
		Advertisement.Show ();
	}

}
