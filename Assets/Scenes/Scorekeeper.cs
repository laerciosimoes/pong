using UnityEngine;
using System.Collections;

public class Scorekeeper : MonoBehaviour
{
	public int ScoreLimit = 10;
    // the display test for player 1's score
    public TextMesh Player1ScoreDisplay;

    // the display text for player 2's score
    public TextMesh Player2ScoreDisplay;
    private int p1Score = 0;
	private int p2Score = 0;

	public void AddScore( int player)
	{
		if (player == 1)
		{
			p1Score++;
		}
		else if (player == 2)
		{
			p2Score++;
		}

		if(p1Score >= ScoreLimit || p2Score >= ScoreLimit)
		{
			if(p1Score > p2Score)
			{
				Debug.Log("Player 1 Wins");
			}
			if(p2Score > p1Score)
			{
				Debug.Log("Player2 Wins");
			}
			else
			{
				Debug.Log("Players are tied");
			}

			// Reset score and start over
			p1Score = 0;
			p2Score = 0;
		}
        // display each player's score
        Player1ScoreDisplay.text = p1Score.ToString();

        Player2ScoreDisplay.text = p2Score.ToString();
    }

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
			
	}
}

