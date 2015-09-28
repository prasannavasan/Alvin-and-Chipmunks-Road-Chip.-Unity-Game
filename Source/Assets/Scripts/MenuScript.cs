
using System.Collections;

using UnityEngine;


public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		const int button1Width = 84;
		const int button1Height = 60;

		const int button2Width = 84;
		const int button2Height = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		Rect button2Rect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 8) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		Rect button1Rect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Start!"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Farm");
		}
		// Draw a button to start the game
		if(GUI.Button(button1Rect,"Stop!"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
		}

		if(GUI.Button(button2Rect,"About Us!"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			//Application.Quit();
		}
	}
}
