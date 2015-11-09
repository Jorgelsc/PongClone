using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	int gameSceneIdx = 1;

	public void GotoGameScene () {
		Application.LoadLevel(gameSceneIdx);
	}

	void Update () {

		if (Input.GetKey(KeyCode.P)) {
			GotoGameScene();
		}

	}

}
