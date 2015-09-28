
using System.Collections;

using UnityEngine;


public class GameOverScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
		
		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Replay"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Farm");
		}

		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Share Scores"
			)
			)
		{
			// Reload the level
			//Application.LoadLevel("Farm");
		}

		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 11) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Invite"
			)
			)
		{
			// Reload the level
			//Application.LoadLevel("Farm");
		}
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Main Menu"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Menu");
		}
	}
}