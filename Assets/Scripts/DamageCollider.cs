using UnityEngine;
using System.Collections;

public class DamageCollider : MonoBehaviour {

	public string m_Tag = "Player";
	public float m_damage = 10.0f;
	public bool m_destroyOnCollision = true;

	public void OnTriggerEnter2D (Collider2D other) {
		if (other.transform.CompareTag(m_Tag)) {
	    	other.gameObject.SendMessage ("damage", m_damage, SendMessageOptions.DontRequireReceiver);
			if (m_destroyOnCollision)
				Destroy(gameObject);
		}
    }
}
