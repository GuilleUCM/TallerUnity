using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene(int sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
	}
}
