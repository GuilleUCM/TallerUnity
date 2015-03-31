using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {

	public float maxHealth = 100f;
	private float health;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;				// The local scale of the health bar initially (with full health).

	void Awake ()
	{
		// Setting up references.
		health = maxHealth;
		healthBar = GameObject.Find("HealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;
		updateHealthBar();
	}
	
	void updateHealthBar() {
		// Set the health bar's colour to proportion of the way between green and red based on the player's health.
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
		
		// Set the scale of the health bar to be proportional to the player's health.
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
	}
	
	void damage(float f)
	{
		health -= f;
		if (health<=0) {
			health = 0;
			gameObject.SendMessage("OnDeath", SendMessageOptions.DontRequireReceiver);
			health = maxHealth;
		}
		updateHealthBar();
	}
	
	
}
