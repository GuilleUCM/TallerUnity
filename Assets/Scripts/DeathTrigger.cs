using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public string m_Tag = "Player";

    public void OnTriggerEnter2D (Collider2D other) {
    	if (other.transform.CompareTag(m_Tag)) {
	        other.gameObject.SendMessage ("OnDeath", SendMessageOptions.DontRequireReceiver);
	    }
    }
}
