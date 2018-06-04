using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PkUpWeapon : MonoBehaviour {
	//Weapon Stats
	[Header("Tweak")]
	public float damage;
	public float fireRate;
	public float reloadRate; //Currently does nothing, no ammo in game yet.
	public float bulletVelocity;
	public int maxClip; //Currently does nothing, no ammo in game yet.
	[Space(10)]
	[Header("And Forget")]
	public string weaponName;
	public int ammoConsuption;
	public GameObject whatBullet; //What type of bullet does it fire?


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
