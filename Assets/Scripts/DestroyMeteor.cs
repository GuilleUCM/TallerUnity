using UnityEngine;
using System.Collections;

public class DestroyMeteor : MonoBehaviour {

	public float minHeight = 0.0f;

	// Update is called once per frame
	void Update () {
		if (transform.position.y <= minHeight)
			Destroy (gameObject);
	}
}
