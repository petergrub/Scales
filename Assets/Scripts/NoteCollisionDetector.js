#pragma strict
var particle : ParticleSystem;
/*
function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "NoteColliderPlane")
    {
        Destroy(gameObject);
        particle.Play();
    }
}*/

function OnTriggerEnter(col:Collider)
 {
     if(gameObject.tag == "NoteColliderPlane")
     {
     	Destroy(gameObject);
        particle.Play();
     }
 }