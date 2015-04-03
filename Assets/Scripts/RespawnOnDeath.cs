using UnityEngine;
using System.Collections;

public class RespawnOnDeath : MonoBehaviour {

	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		if (spawnPoint!=null)
			gameObject.transform.position = spawnPoint.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnDeath() {
//		gameObject.transform.position = spawnPoint.position;
//		GameObject root = GameObject.FindGameObjectWithTag("Root");
//		if (root!=null)
//			gameObject.transform.parent = root.transform;
//		else 
//			gameObject.transform.parent = null;
		Application.LoadLevel(0);
	}
}
