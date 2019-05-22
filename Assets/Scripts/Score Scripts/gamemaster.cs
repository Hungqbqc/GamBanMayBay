using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemaster : MonoBehaviour 
{
	public static gamemaster instance;
	public int points;
	public Text pointtext;


	void Update ()
	{
		pointtext.text = "" + points ;
	}
}
