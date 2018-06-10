using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponAmmoUI : MonoBehaviour {

	CurrentWeapon weapon;
	// Use this for initialization
	void Start () {
		weapon = FindObjectOfType<CurrentWeapon> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = weapon.ammo.ToString();
		if (weapon.ammo == 0) {
			this.GetComponent<Text> ().color = new Color (255, 0, 0);
		} else {
			this.GetComponent<Text> ().color = new Color (255, 255, 255);
		}
	}
}
