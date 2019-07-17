using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject Winner;
	public Text WinnerText;

	public Text Player1ScoreText;
	public Text Player2ScoreText;

	public int Player1Score = 0;
	public int Player2Score = 0;

	public bool GameOver = false;

	void Start () {
	}

	void FixedUpdate () 
	{
		Player1ScoreText.text = "Player 1: " + Player1Score;
		Player2ScoreText.text = "Player 2: " + Player2Score;
		if (Player1Score == 10) {
			Winner.SetActive(true);
			GameOver = true;
			WinnerText.text = "Player 1 Wins. " +
				"Press R to Restart!";
		}
		if (Player2Score == 10) {
			Winner.SetActive(true);
			GameOver = true;
			WinnerText.text = "Player 2 Wins." +
				"Press R to Restart!";
		}

		if (Input.GetKey(KeyCode.R))
		{
			Player1Score = 0;
			Player2Score = 0;
			Winner.SetActive(false);
			GameOver = false;
		}
	}
}
