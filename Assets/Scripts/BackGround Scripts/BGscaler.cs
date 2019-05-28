using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscaler : MonoBehaviour 
{

	void Start () 
	{
		var worldHeight = Camera.main.orthographicSize * 2f;    // lấy chiều rộng của màn hình
		var worldWidth = worldHeight * Screen.width / Screen.height; // lấy chiều dài của màn hình
        transform.localScale = new Vector3 (worldWidth, worldHeight, 0f);   // làm cho hình nền tự dãn theo độ phân giải của máy
	}
}
