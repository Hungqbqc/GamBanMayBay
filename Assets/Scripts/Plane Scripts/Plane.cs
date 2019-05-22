﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour 
{
	public float planeSpeed;
	private Rigidbody2D myBody;

//	public AudioClip[] audioClip;

	[SerializeField]
	private GameObject bullet;

	private bool canShoot = true;

	void Awake () 
	{
		myBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () 
	{
		PlaneMovement ();
	}
	void Update()
	{
        // nếu bấm phím Space thì bắn đạn
		if (Input.GetKey (KeyCode.Space))
		{
			if (canShoot) 
			{
				StartCoroutine (Shoot ());
			}
		}
	}
    /// <summary>
    /// hàm máy bay di chuyển
    /// </summary>
	void PlaneMovement()
	{
		float xAxis = Input.GetAxisRaw ("Horizontal") * planeSpeed; // di chuyển theo chiều ngang
		float yAxis = Input.GetAxisRaw ("Vertical") * planeSpeed;// di chuyển theo chiều dọc
        myBody.velocity = new Vector2 (xAxis, yAxis);   // gán tọa độ đã di chuyển
	}

    // hàm bắn viên đạn sau 1 khoảng thời gian
	IEnumerator Shoot()
	{
//		PlayShound (0);
		canShoot = false;
		Vector3 temp = transform.position;
		temp.y += 0.6f;
		Instantiate (bullet, temp, Quaternion.identity);
		yield return new WaitForSeconds (1f);
		canShoot = true;
	}
	/*
	void PlayShound(int clip)
	{
		GetComponent<AudioSource>().clip = audioClip[clip];
		GetComponent<AudioSource> ().Play();
	}*/
}
