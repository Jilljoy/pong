using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject Winner;
	public Text WinnerText;

	public Text Player1ScoreText;
	public Text Player2ScoreText;

    private int player1Score = 0;
    private int player2Score = 0;

    /// <summary>
    /// Is the game currently over or not?
    /// </summary>
    public bool GameOver = false;

    public int Player1Score
    {
        get => player1Score;

        set
        {
            player1Score = value;
            Player1ScoreText.text = "Player 1:" + player1Score;
        }
    }

    public int Player2Score
    {
        get => player2Score;

        set
        {
            player2Score = value;
            Player2ScoreText.text = "Player 2:" + player2Score;

        }
    }

    void Start () {
	}

	void FixedUpdate () 
	{
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
