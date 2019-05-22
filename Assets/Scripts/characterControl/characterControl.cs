using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class characterControl : MonoBehaviour 
{

	Vector3 position;

	public GameObject dan;

	public AudioClip[] audioClip;
	int clip;

	void FixedUpdate () 
	{
		position = new Vector3 (CnInputManager.GetAxis ("Horizontal"),CnInputManager.GetAxis ("Vertical"),0f);
		transform.position += position * Time.deltaTime * 4;
		if (position.x < 0) 
		{
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		else
		{
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}

		if (CnInputManager.GetButtonUp ("Jump"))
		{
			Instantiate (dan, transform.position, Quaternion.identity);

			GetComponent<AudioSource>().clip = audioClip[clip];
			GetComponent<AudioSource> ().Play();
		}

	}
}
