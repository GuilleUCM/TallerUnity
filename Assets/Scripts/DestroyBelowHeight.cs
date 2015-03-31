using UnityEngine;
using System.Collections;

public class DestroyBelowHeight : MonoBehaviour {

	public float minHeight = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= minHeight)
			Destroy (gameObject);
	}
}
