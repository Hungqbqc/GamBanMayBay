using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
	[SerializeField]
	private float speed;
	private Rigidbody2D myBody;

	public int score = 0;
	// Use this for initialization
	void Awake() 
	{
		myBody = GetComponent<Rigidbody2D> ();
	}
	void Start()
	{
		speed = Random.Range (-4, -1);
		myBody.angularVelocity = Random.Range (0, 200);
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		myBody.velocity = new Vector2 (myBody.velocity.x, speed);
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Player") 
		{
			Destroy (target.gameObject);
			GamePlayController.instance.PlaneDiedShowPanel ();
		}

		if (target.tag == "Border") 
		{
			Destroy (gameObject);
		}
	}
}
