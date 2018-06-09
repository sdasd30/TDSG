using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]
public class Attackable : MonoBehaviour {
	public float maxHP = 1;
	public bool allied;
	public bool anarchy;
	CreatesDebris createsDebris;
	float hp;
	// Use this for initialization
	void Start () {
		hp = maxHP;
		createsDebris = GetComponent<CreatesDebris> ();
	}

	// Update is called once per frame
	void Update () {
		if (hp <= 0){
			if (createsDebris != null) {
				createsDebris.generateDebris();
			}
			Destroy (this.gameObject);
		}
	}
	public void TakeDamage(float damage){
		hp -= damage;
	}
	public float returnHP() {
		return hp;
	}
}
