using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public int finalscore = 0;
	public static score instance;
    public Text scoretext, gameover;
	public int previousHighScore;

	void Start()
	{
		instance = this;
		previousHighScore =	PlayerPrefs.GetInt ("HighScore");
	}

	void OnTriggerEnter2D(Collider2D test)
	{
	//	int status = FlyControl.birdstatus (); 
		//if (FlyControl.update.dead == 1) 
		finalscore++;
		scoretext.text = "score: " + finalscore;
	}

	public void UpdateScore()
	{
		Debug.Log ("gameover script running");
		if (finalscore > previousHighScore) {
			PlayerPrefs.SetInt ("HighScore", finalscore);
		}
		previousHighScore = PlayerPrefs.GetInt ("HighScore");
		gameover.text = "Gameover \nHighscore:" + previousHighScore;
	}
}
