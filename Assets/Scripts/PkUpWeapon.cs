using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PkUpWeapon : MonoBehaviour {
	public float pickupRadius;
	public GameObject E;
	GameObject instatiated ;
	MvmtBody player;
	Vector3 playerPosition;
	Vector3 m_Position;
	bool inRange;
	// Use this for initialization
	void Start () {
		pickupRadius = 1;
		player = FindObjectOfType<MvmtBody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		playerPosition = player.transform.position;
		m_Position = this.transform.position;
		float dist = Vector3.Distance (playerPosition, m_Position);	
		if (dist <= pickupRadius) {
			if (!inRange) {
				//Vector3 localOffset = new Vector3 (0, 1, 0);
				//Vector3 worldOffset = transform.rotation * localOffset;
				instatiated = Instantiate (E,m_Position + new Vector3(0,1,0), Quaternion.identity);
			}
			inRange = true;
		} else {
			Destroy (instatiated);
			inRange = false;

		}


	}
}
