using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;

	public Text scoreTextP1;
	public Text scoreTextP2;

	private int scoreP1 = 0;
	private int scoreP2 = 0;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	public void incrementScore(int playerIdx) {

		if (playerIdx == 1) {
			scoreP1++;
			scoreTextP1.text = "" + scoreP1;
		} else if (playerIdx == 2) {
			scoreP2++;
			scoreTextP2.text = "" + scoreP2;
		}

	}


}
