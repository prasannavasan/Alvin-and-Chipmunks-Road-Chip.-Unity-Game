using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public int score = 0; // The player's score.
	private int previousScore = 0; // The score in the previous frame.

	// Use this for initialization
	void Start () {

		GetComponent<GUIText> ().color = Color.blue;
		GetComponent<GUIText>().fontSize = 50;
	
	}
	
	// Update is called once per frame
	void Update () {

		// Set the score text.
		GetComponent<GUIText>().text = "Score: " + score;
		// Set the previous score to this frame's score.
		previousScore = score;
	
	}
}
