using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	private Text text = null;

	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text>();	
		int highscore = PlayerPrefs.GetInt("HighScore",0);
		text.text = "Best Score: " + highscore;
	}

	
	// Update is called once per frame
	void Update () {

	
	}
}
