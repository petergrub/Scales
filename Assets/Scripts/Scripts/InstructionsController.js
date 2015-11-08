#pragma strict

//var levelToLoad : String;
//var instructions : GameObject;
//var instructionsPanel : GameObject;
//var instructionsText : String; //enter in instructions for the player

var instructionsPanel1 : GameObject;
var instructionsPanel2 : GameObject;
var instructionsPanel3 : GameObject;
var instructionsPanel4 : GameObject;
var instructionsPanel5 : GameObject;
var count : int = 2;

function Start(){
	instructionsPanel1.SetActive(true);
}

function ShowInstructions() {
	switch(count) {
	case 1:
		instructionsPanel1.SetActive(true);
		count++;
		break;
	case 2:
		instructionsPanel1.SetActive(false);
		instructionsPanel2.SetActive(true);
		count++;
		break;
	case 3:
		instructionsPanel2.SetActive(false);
		instructionsPanel3.SetActive(true);
		count++;
		break;
	case 4:
		instructionsPanel3.SetActive(false);
		instructionsPanel4.SetActive(true);
		count++;
		break;
	case 5:
		instructionsPanel4.SetActive(false);
		instructionsPanel5.SetActive(true);
		count = 1;
		break;
	}
}

function HideInstructions() {
	instructionsPanel5.SetActive(false);
}