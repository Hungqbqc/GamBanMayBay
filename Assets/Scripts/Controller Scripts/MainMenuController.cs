using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // nếu là nhấn vào nút Play
	public void PlayGameButton()
	{
		Application.LoadLevel ("GamePlay");
	}

    // nhấn nút giới thiệu
	public void GioiThieuButton()
	{
		Application.LoadLevel ("CachChoi");
	}

    // Nhấn nút quit
	public void QuitGameButton()
	{
		Debug.Log ("Bye bye!!!");
		Application.Quit ();
	}
}
