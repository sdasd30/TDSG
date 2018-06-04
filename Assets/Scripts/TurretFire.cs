using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour {
	TurretEnemy turret;
	Rigidbody projectile;
	public Vector2 offset;
	public GameObject projectilePrefab;
	public float firerate;
	float cooldown;
	// Use this for initialization
	void Start () {
		cooldown = 0;
		turret = GetComponent<TurretEnemy>();
	}
	
	// Update is called once per frame
	void Update () {
		{
			if (Mathf.Abs (Mathf.DeltaAngle (turret.direction, turret.angle) + 90) < 4) {
				if (cooldown <= 0) { 
					float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
					GameObject bullet = GameObject.Instantiate (projectilePrefab, transform.position + new Vector3 (offset.x * Mathf.Cos (angle), offset.y * Mathf.Sin (angle), 0f), Quaternion.identity);
					bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z);
					Destroy (bullet, 5);
					cooldown = firerate;
				}
			}
			cooldown--;
		}
	}
}
