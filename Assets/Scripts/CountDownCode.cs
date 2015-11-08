using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownCode : MonoBehaviour {
	float timeRemaining = 5.0f;
	public Text text;
	
	
	public void Start () {
		text = GetComponent<Text>();
		text.text = "\nPress the SpaceBar to begin";
		
		if (Input.GetKeyDown ("space")) {
			timeRemaining -= Time.deltaTime;
			
			if (timeRemaining == 3) {
				text.text = "3";
			} else if (timeRemaining == 2) {
				text.text = "2";
			} else if (timeRemaining == 1) {
				text.text = "1";
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
