#pragma strict
 
function OnTriggerEnter (other : Collider){
    if (other.gameObject.tag == "RhythmStall"){
        //Line 5 (Load your level here...)
        Application.LoadLevel("RhythmMiniGame");
    }
}