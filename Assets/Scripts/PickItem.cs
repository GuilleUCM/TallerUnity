using UnityEngine;
using System.Collections;

public class PickItem : MonoBehaviour {

	public float m_score = 100f;
	
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.CompareTag("Player")) {
			col.SendMessage("AddScore", m_score);
			Destroy(gameObject);
		}
	}
}
