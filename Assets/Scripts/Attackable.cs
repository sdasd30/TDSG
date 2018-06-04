using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]
public class Attackable : MonoBehaviour {
	public float maxHP = 1;
	public bool allied;
	public bool anarchy;
	float hp;
	// Use this for initialization
	void Start () {
		hp = maxHP;
	}

	// Update is called once per frame
	void Update () {
		if (hp <= 0){
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
