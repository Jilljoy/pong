using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    /** The maximum score a player needs to achieve before a winner is declared. */
    private static readonly int HIGHSCORE = 10;

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

    void FixedUpdate () 
	{
		if (Player1Score == HIGHSCORE) {
            PlayerWon(1);
		}
		if (Player2Score == HIGHSCORE) {
            PlayerWon(2);
		}

		if (Input.GetKey(KeyCode.R))
		{
            RestartGame();
		}
	}

    private void PlayerWon(int player)
    {
        GameOver = true;
        WinnerText.text = "Player " + player + " Wins. Press R to Restart!";
        Winner.SetActive(true);
    }

    private void RestartGame()
    {
        Player1Score = 0;
        Player2Score = 0;
        Winner.SetActive(false);
        GameOver = false;
    }
}
