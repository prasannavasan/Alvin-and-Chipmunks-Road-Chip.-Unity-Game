using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	// Use this for initialization
	public int health = 10; // The player's score.
	//private int previoushealth = 10; // The score in the previous frame.

	void Start () {
		GetComponent<GUIText>().fontSize = 50;
		GetComponent<GUIText> ().color = Color.red;
		health = 10;
	
	}
	
	// Update is called once per frame
	void Update () {
		// Set the score text.
		GetComponent<GUIText>().text = "Health: " + health;
		// Set the previous score to this frame's score.
		//previoushealth = health;
	
	}
}
