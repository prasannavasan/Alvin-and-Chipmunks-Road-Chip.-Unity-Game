using UnityEngine;
using System.Collections;


public class HealthScript : MonoBehaviour
{

	public int hp = 2;
	

	public bool isEnemy = true;
	

	public void Damage(int damageCount)
	{
		hp -= damageCount;
		
		if (hp <= 0)
		{
			// 'Explosion!
			SpecialEffectsHelper.Instance.Explosion(transform.position);

			SoundEffectsHelper.Instance.MakeExplosionSound();

			// Dead!
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null)
		{
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				
				// Destroy the shot
				Destroy(shot.gameObject); 
			}
		}
	}
}