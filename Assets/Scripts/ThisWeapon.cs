using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisWeapon : MonoBehaviour {
	//Weapon Stats
	[Header("Tweak")]
	public float damage;
	public float fireRate;
	public float bulletVelocity;
	public float ammo;
	[Space(10)]
	[Header("And Forget")]
	public string weaponName;
	//public int ammoConsuption;
	public GameObject whatBullet; //What type of bullet does it fire?
}
