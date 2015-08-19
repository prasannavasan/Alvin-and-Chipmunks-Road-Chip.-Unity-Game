﻿using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private WeaponScript[] weapons;
	
	void Awake()
	{
		// Retrieve the weapon only once
		weapons = GetComponentsInChildren<WeaponScript>();
	}
	
	void Update()
	{
		foreach (WeaponScript weapon in weapons)
		{
			// Auto-fire
			if (weapon != null && weapon.CanAttack)
			{
				weapon.Attack(true);
			}
		}
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		bool damagePlayer = false;
		
		// Collision with enemy
		EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
		if (enemy != null)
		{
			// Kill the enemy
			HealthScript enemyHealth = enemy.GetComponent<HealthScript>();
			if (enemyHealth != null) enemyHealth.Damage(enemyHealth.hp);
			
			damagePlayer = true;
		}
		
		// Damage the player
		if (damagePlayer)
		{
			HealthScript playerHealth = this.GetComponent<HealthScript>();
			if (playerHealth != null) playerHealth.Damage(1);
		}
	}
}