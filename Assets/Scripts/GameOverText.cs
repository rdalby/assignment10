using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOverText : MonoBehaviour {

	private Text text;

	void OnTriggerEnter(Collider other) {
		GameObject wonTxt = GameObject.Find("GameOver");
		text = wonTxt.GetComponent<Text>();
		
		text.color = new Color(0, 0, 0, 1);
		text.text = "YOU WON!";
			

	}
}
