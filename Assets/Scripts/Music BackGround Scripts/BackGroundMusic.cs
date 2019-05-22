using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour 
{
	public static BackGroundMusic instance;
	// Use this for initialization
	void Awake ()
	{
		MakeSingleton ();
	}
	
	// Update is called once per frame
	void MakeSingleton ()
	{
		if (instance != null) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}
}
