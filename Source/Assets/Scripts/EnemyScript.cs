using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private bool hasSpawn;
	private MoveScript moveScript;
	private WeaponScript[] weapons;
	
	void Awake()
	{

		weapons = GetComponentsInChildren<WeaponScript>();
		
	
		moveScript = GetComponent<MoveScript>();
	}
	

	void Start()
	{
		hasSpawn = false;
		
	
		GetComponent<Collider2D>().enabled = false;

		moveScript.enabled = false;
	
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = false;
		}
	}
	
	void Update()
	{
	
		if (hasSpawn == false)
		{
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		}
		else
		{
		
			foreach (WeaponScript weapon in weapons)
			{
				if (weapon != null && weapon.enabled && weapon.CanAttack)
				{
					weapon.Attack(true);
					SoundEffectsHelper.Instance.MakeEnemyShotSound();
				}
			}
			
		
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}
	}
	

	private void Spawn()
	{
		hasSpawn = true;
		
	
		GetComponent<Collider2D>().enabled = true;
	
		moveScript.enabled = true;
	
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = true;
		}
	}
}