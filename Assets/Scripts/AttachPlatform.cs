using UnityEngine;
using System.Collections;

public class AttachPlatform : MonoBehaviour {

	private Transform prevParent;

	void OnTriggerEnter2D(Collider2D other) {
		Transform parent = other.transform.parent;
		if (parent!=gameObject.transform) {
			prevParent = other.transform.parent;
			other.transform.parent = gameObject.transform;
		}
	}
	
	void OnTriggerExit2D(Collider2D other) {
		other.transform.parent = prevParent;
	}
}
