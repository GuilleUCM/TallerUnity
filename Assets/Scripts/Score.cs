using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Score : MonoBehaviour {

	public GUISkin m_skin;
	public Vector2 m_offset;
	public Vector2 m_size;
	private int m_score = 0;
	
	void OnGUI()
	{
		//SCORE
		
		//GUI.skin = m_skin;
		GUI.TextArea(new Rect(Screen.width * m_offset.x,Screen.height * m_offset.y,  Screen.width* m_size.x, Screen.height * m_size.y), "Score: " + m_score, m_skin.GetStyle("textarea"));
	
	}
	
	void AddScore(int f)
	{
		m_score += f;
	}
	
	void SetScore(int f)
	{
		m_score = f;
	}

	void SaveScore() {
		int highscore = PlayerPrefs.GetInt("HighScore",0);
		if (m_score > highscore) {
			PlayerPrefs.SetInt("HighScore", m_score);

		}
	}
	
	
}
