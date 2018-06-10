using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponNameUI : MonoBehaviour {

	CurrentWeapon weapon;
	// Use this for initialization
	void Start () {
		weapon = FindObjectOfType<CurrentWeapon> ();
	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = weapon.name;
	}
}
