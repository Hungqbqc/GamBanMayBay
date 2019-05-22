using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour 
{

	public static GamePlayController instance;

	[SerializeField]
	private GameObject pausePanel, gameOverPanel;

	private scoremanager theScoremanager;
    public Sprite[] fruitSprites;
    void Start()
	{
		theScoremanager = FindObjectOfType<scoremanager> ();
    }
	void Awake()
	{
		MakeInstance ();
	}
		
	void MakeInstance()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}		

	public void PauseGameButton()
	{
		pausePanel.SetActive (true);
		Time.timeScale = 0f;
	}

	public void ResumeButton()
	{
		pausePanel.SetActive (false);
		Time.timeScale = 1f;
	}

	public void OptionsButton()
	{
        Time.timeScale = 1f;
        Application.LoadLevel ("MainMenu");
	}

	public void ReStartButton()
	{
		theScoremanager.scoreIncreasing = false;
        Time.timeScale = 1f;

        gameOverPanel.SetActive (false);
		Application.LoadLevel ("GamePlay");

		theScoremanager.scoreCount = 0;
		theScoremanager.scoreIncreasing = true;

	}

    // Hiển thị Panel Die sau khi game over
	public void PlaneDiedShowPanel()
	{
        Time.timeScale = 0f;    // dừng game
        gameOverPanel.SetActive (true); // hiển thị panel
	}

    // Reset điểm
	public void ResetBestScore()
	{
		theScoremanager.hiScoreCount = 0;
		PlayerPrefs.SetFloat ("BestScore", theScoremanager.hiScoreCount);
	}
}
