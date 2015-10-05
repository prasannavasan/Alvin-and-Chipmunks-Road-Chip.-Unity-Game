using UnityEngine;
using System.Collections;


public class HealthScript : MonoBehaviour
{

	public int hp = 10;

	private ScoreController score;
	private HealthController health;
	

	public bool isEnemy = true;
	void Start()
	{

		score = GameObject.Find("Score").GetComponent<ScoreController>();
		health = GameObject.Find("Health").GetComponent<HealthController>();
	}

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

	void Update()
	{

	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null)
		{
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy)
			{
				if (otherCollider.gameObject.tag != "Hey") {
					score.score += 1;
				}
				Damage(shot.damage);
				//score.score += 1;
				
				health.health -= 1;
				// Destroy the shot
				Destroy(shot.gameObject); 

			}
		}
	}
}