using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileStyleHolder : MonoBehaviour {

	public static TileStyleHolder Instance; //creating a singleton
	public TileStyle [] TileStyles;

	void Awake()
	{
		Instance = this;
	}
}
	
[System.Serializable]
public class TileStyle
{
	public int Number;
	public Color32 TileColor; 
	public Color32 TextColor;
}