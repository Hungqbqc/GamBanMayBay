using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour 
{
	public static scoreText instance;
	public static int scoretext = 0;
	Text score;
	// Use this for initialization
	void Awake () 
	{
		score = GetComponent<Text> ();
	}
	// Update is called once per frame
	public void FixedUpdate () 
	{
		score.text = "" + scoretext;
	}

	public static void Reset()
	{
		scoretext = 0;
	}
}
