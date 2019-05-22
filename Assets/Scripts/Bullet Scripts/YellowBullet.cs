using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour 
{
	public float speed;
	private Rigidbody2D myBody;

	private scoremanager gm;

	void Awake () 
	{
		myBody = GetComponent<Rigidbody2D> ();

		gm = GameObject.FindGameObjectWithTag ("ScoreManager").GetComponent<scoremanager> ();
	}

	void FixedUpdate () 
	{
		myBody.velocity = new Vector2 (0f, speed);
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Border") 
		{
			Destroy (gameObject);
		}

		if (target.tag == "Enemy") 
		{
			Destroy (target.gameObject);

			if (gm.scoreIncreasing)
			{
				gm.scoreCount += 1;
			}
			Destroy (gameObject);
		}
			
		if (target.tag == "Rock") 
		{
			Destroy (target.gameObject);

			if (gm.scoreIncreasing)
			{
				gm.scoreCount += 1;
			}
			Destroy (gameObject);
		}
	}
}
