using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RhythmGameCode : MonoBehaviour {
	float timeRemaining = 5.0f;
	public GameObject note1;
	public GameObject note1active;
	public GameObject note2;
	public GameObject note2active;
	public GameObject note3;
	public GameObject note3active;
	public GameObject note4;
	public GameObject note4active;


	public void Start () {
		note1.GetComponent<Renderer>().enabled = true;
		note2.GetComponent<Renderer>().enabled = true;
		note3.GetComponent<Renderer>().enabled = true;
		note4.GetComponent<Renderer>().enabled = true;
	}

	void Update() {
		timeRemaining -= Time.deltaTime;
		if (Input.GetKeyDown ("space")) {
			if (timeRemaining > 3.5 & timeRemaining < 4.5) {	//First note with .5 sec buffer
				note1active.GetComponent<Renderer>().enabled = true;
			} 
			else if (timeRemaining > 2.5 & timeRemaining < 3.5) {
				note2active.GetComponent<Renderer>().enabled = true;
			} 
			else if (timeRemaining > 1.5 & timeRemaining < 2.5) {
				note3active.GetComponent<Renderer>().enabled = true;
			}
			else if (timeRemaining > .5 & timeRemaining < 1.5) {
				note4active.GetComponent<Renderer>().enabled = true;
			}
		}
	}
}
