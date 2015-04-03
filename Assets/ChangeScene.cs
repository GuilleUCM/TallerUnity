using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void ChanegToScene(int sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
	}
}
