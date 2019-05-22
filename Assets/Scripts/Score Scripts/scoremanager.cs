using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour 
{
	public static scoremanager instance;

	public Text scoreText, hiScoreText;
	public float scoreCount, hiScoreCount;
	public bool scoreIncreasing;

	void Start()
	{
		if (PlayerPrefs.HasKey ("BestScore"))
		{
			hiScoreCount = PlayerPrefs.GetFloat("BestScore");
		}
	}

	void Awake()
	{
		MakeInstance ();
	}

	void MakeInstance()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}		
		
	void Update () 
	{
		
		if (scoreCount > hiScoreCount) 
		{
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("BestScore", hiScoreCount);
		}
		scoreText.text = "" + Mathf.Round (scoreCount);
		hiScoreText.text = "" + Mathf.Round (hiScoreCount);
	}
}
