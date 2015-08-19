using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	//Speed of Alvin automobile
	public Vector2 speed = new Vector2(50, 50);
	

	private Vector2 movement;
	
	void Update()
	{
		// Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		//  Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);

		// Shooting
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");

		
		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(false);
			}
		}
		
	}
	
	void FixedUpdate()
	{
		//  Move the game object
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}