using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody2D))]

public class TurretEnemy : MonoBehaviour {
	Rigidbody2D m_body;
	public float rotSpeed;
	public float direction;
	public float angle;
	MvmtBody player;
	// Use this for initialization
	void Start () {
		m_body = GetComponent<Rigidbody2D> ();
		player = GameObject.FindObjectOfType<MvmtBody>();
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 playerPos = player.transform.position;
			Vector2 currentPos = new Vector2 (transform.position.x, transform.position.y);
			direction = (Mathf.Atan2 (playerPos.y - currentPos.y, playerPos.x - currentPos.x)) * Mathf.Rad2Deg;
			angle = Mathf.MoveTowardsAngle (transform.eulerAngles.z, direction - 90, rotSpeed * Time.deltaTime);
			m_body.transform.rotation = Quaternion.Euler (new Vector3 (0f, 0f, angle));
		} else {
			direction = 0;
			angle = 180;
		}

	}
}
