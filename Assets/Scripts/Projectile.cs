using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Projectile : MonoBehaviour {
	Rigidbody2D m_body;
	public float speed;
	public float damage;
	public bool isAllied;
	public bool anarchy;

	public void SetAngle (float rotation) {
		m_body.transform.rotation = Quaternion.Euler (new Vector3(0f,0f,rotation));
	}

	void Awake () {
		m_body = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		m_body.transform.Translate (new Vector2(0f,speed * Time.deltaTime)); //new Vector2 (Mathf.Cos(angle) * speed * Time.deltaTime,Mathf.Sin(angle) * speed * Time.deltaTime));

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.GetComponent<Solid> () != null) {
			Destroy (this.gameObject);
		}
		if (other.gameObject.GetComponent<Attackable> () != null) {
			Destroy (this.gameObject);
			Attackable a = other.gameObject.GetComponent<Attackable> ();
			if (a.anarchy) {
				a.TakeDamage (damage);
			} else if (isAllied && !a.allied) {
				a.TakeDamage (damage);
			} else if (!isAllied && a.allied) {
				a.TakeDamage (damage);
			}
		}
	}
}
