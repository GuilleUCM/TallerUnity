using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public float minSpawnTime;
	public float maxSpawnTime;

	public Rigidbody2D entity;

	private float currentTime;
	private float maxTime;

	private float minPosX;
	private float maxPosX;



	// Use this for initialization
	void Start () {
		Random.seed = 12345; //System.DateTime.Today.Millisecond;
		currentTime = 0.0f;
		maxTime = Random.Range(minSpawnTime, maxSpawnTime);
		minPosX = transform.position.x - transform.localScale.x/2;
		maxPosX =  transform.position.x + transform.localScale.x/2;

		// Calcular minPosX maxPosX a partir del transform
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		Debug.Log(currentTime + " "+ maxTime);
		if (currentTime>= maxTime) {
			currentTime = 0.0f;
			maxTime = Random.Range(minSpawnTime, maxSpawnTime);

			float posX = Random.Range(minPosX, maxPosX);
			float posY = gameObject.transform.position.y;
			Vector3 spawnPos = new Vector3(posX, posY, 0);

			// Instantiate the prop at the desired position.
			Rigidbody2D instance = Instantiate(entity, spawnPos, Quaternion.identity) as Rigidbody2D;

		}
	}
}
