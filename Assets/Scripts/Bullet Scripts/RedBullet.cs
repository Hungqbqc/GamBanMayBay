using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
	public float speed;
	private Rigidbody2D myBody;


	void Awake () 
	{
		myBody = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
        // cho viên đạn bắn xuống
		myBody.velocity = new Vector2 (0f, -speed);
	}

	void OnTriggerEnter2D(Collider2D target)
	{
        // nếu đạn địch chạm vào máy bay mình thì game over
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
