using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBound : MonoBehaviour 
{
	private float minX, maxX, minY, maxY;

	// Use this for initialization
	void Start () 
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0f));
		minX = -bounds.x + 0.3f;
		maxX = bounds.x - 0.3f;

		minY = -bounds.y + 0.4f;
		maxY = bounds.y - 0.4f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 temp = transform.position;  // lấy vị trí hiện tại máy bay

        // cố định máy bay trong màn hình chơi
		if (temp.x < minX) {
			temp.x = minX;
		} else if (temp.x > maxX) 
		{
			temp.x = maxX;
		}

		if (temp.y < minY) {
			temp.y = minY;
		} else if (temp.y > maxY) 
		{
			temp.y = maxY;
		}
        // gán lại vị trí máy bay
		transform.position = temp;
	}
}
