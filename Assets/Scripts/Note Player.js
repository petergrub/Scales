#pragma strict

var transpose = -4;  // transpose in semitones
var pitch;
 
function Start() {
    var audio: AudioSource = GetComponent.<AudioSource>();
    //audio.Play();
    //audio.Play(44100);
}

function Update(){
 
    var note = -1; // invalid value to detect when note is pressed
    if (Input.GetKeyDown("a")) note = 0;  // C
    if (Input.GetKeyDown("w")) note = 1;
    if (Input.GetKeyDown("s")) note = 2;  // D
    if (Input.GetKeyDown("e")) note = 3;
    if (Input.GetKeyDown("d")) note = 4;  // E
    if (Input.GetKeyDown("f")) note = 5;  // F
    if (Input.GetKeyDown("t")) note = 6;
    if (Input.GetKeyDown("g")) note = 7;  // G
    if (Input.GetKeyDown("y")) note = 8;
    if (Input.GetKeyDown("h")) note = 9;  // A
    if (Input.GetKeyDown("u")) note = 10;
    if (Input.GetKeyDown("j")) note = 11; // B
    if (Input.GetKeyDown("k")) note = 12; // C
    if (Input.GetKeyDown("o")) note = 13;
    if (Input.GetKeyDown("l")) note = 14; // D
    if (Input.GetKeyDown("p")) note = 15;
     
    //if (Input.anyKeyDown) note = 1; //Any key is pressed

    if (note>=0){ // if some key pressed...
    	pitch = Mathf.Pow(2, (note+transpose)/12.0);
        GetComponent.<AudioSource>().pitch = pitch;
        GetComponent.<AudioSource>().Play();
        //Start();
    }
}  