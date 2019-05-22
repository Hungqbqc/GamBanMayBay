using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscrolling : MonoBehaviour 
{
	public float scrollSpeed;       // tốc độ cuộn hình nền
	private Material mat;   // 
	private Vector2 offset = Vector2.zero;
	void Awake()
	{
		mat = GetComponent<Renderer> ().material;
	}
	// Use this for initialization
	void Start () 
	{
		offset = mat.GetTextureOffset ("_MainTex");
	}	
	// Update is called once per frame
	void Update () 
	{
		offset.y += scrollSpeed * Time.deltaTime;   // cho hình nền di chuyển
		mat.SetTextureOffset ("_MainTex", offset);
	}
}
