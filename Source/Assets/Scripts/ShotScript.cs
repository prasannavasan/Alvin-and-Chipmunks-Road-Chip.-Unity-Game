using UnityEngine;
using System.Collections;


public class ShotScript : MonoBehaviour
{

	public int damage = 1;
	

	public bool isEnemyShot = false;
	
	void Start()
	{
		//  Limited time to live to avoid any leak 20sec
		Destroy(gameObject, 20); 
	}
}