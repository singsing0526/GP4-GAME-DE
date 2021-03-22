using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount3 : MonoBehaviour
{

	public static int score;
	public static Text scoreText;

	void Start()
	{
		scoreText = GetComponent<Text>();
		UpdateScore(0);
	}

	public static void UpdateScore(int value)
	{
		score += value;
		PlayerPrefs.SetInt("scoreData", score);
		scoreText.text = "Player 3 Score: " + score.ToString();
	}
}
