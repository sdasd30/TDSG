using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatter : MonoBehaviour {
	public float velocityMaximum;
	public float velocityMinimum;
	public float rotationMaximum;
	public float rotationMinimum;
	public float lengthMaximum;
	public float lengthMinimum;
	float speed,angle,rotation,time;
	bool clockwise;
	int spentTime;
	// Use this for initialization
	void Start () {
		speed = Random.Range (velocityMinimum, velocityMaximum);
		angle = Random.Range (0, 360);
		clockwise = truefalse (.5f);
		rotation = Random.Range (rotationMinimum, rotationMaximum);
		time = Random.Range (lengthMinimum, lengthMaximum);
		time = Mathf.Round (time);
		spentTime = 0;
	}

	bool truefalse(float zeroToOne){
		return (Random.Range (0f, 1f) <= zeroToOne);
	}

	// Update is called once per frame
	void Update () {
		spentTime++;
		time--;
		if (time < 0) {
			Destroy (GetComponent<Rigidbody2D> ());
			gameObject.GetComponent<Scatter> ().enabled = false;
		}
		Vector3 newVel = new Vector3 (Mathf.Cos (angle) * speed, Mathf.Sin (angle) * speed, 0);
		this.GetComponent<Rigidbody2D> ().velocity = newVel * Time.deltaTime;
		if (clockwise) {
			transform.Rotate (0, 0, rotation * Time.deltaTime);
		} else {
			transform.Rotate (0, 0, -rotation * Time.deltaTime);
		}


		if (spentTime > time / 2) {
			speed -= speed / (time/2);
			rotation -= rotation / (time/2);
		}
		if (speed < 0)
			speed = 0;
		if (rotation < 0)
			rotation = 0;

	}
}
