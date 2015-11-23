#pragma strict
var lifeTime : float = .5;
var particle : ParticleSystem;

function Start () {

	Destroy(gameObject, lifeTime);
	particle.Play();
}

function Update () {

}