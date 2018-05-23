using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvmtBody : MonoBehaviour {
	public float walkSpeed;
	[HideInInspector] public bool moving;
	Rigidbody2D mBody;
	AnimatorSprite mAnim;

	void Start(){
		mBody = GetComponent<Rigidbody2D> ();
		mAnim = GetComponent<AnimatorSprite> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 vel = new Vector3 ();
		bool up, down, right,left;
		up = false;
		down = false;
		right = false;
		left = false;
		moving = false;

		if (Input.GetKey ("w")) {
			vel.y += 1;
			up = true;
			moving = true;
		} else if (Input.GetKey ("s")) {
			vel.y += 1;
			down = true;
			moving = true;
		}

		// no else here. Combinations of up/down and left/right are fine.
		if (Input.GetKey ("a")) {
			vel.y += 1;
			left = true;
			moving = true;
		} else if (Input.GetKey ("d")) {
			vel.y += 1;
			right = true;
			moving = true;
		}
			

		if (moving) {
			float angle = 0;
			vel = Vector3.Normalize (vel);
			vel *= walkSpeed;
			vel *= Time.deltaTime;
			mBody.transform.Translate (vel);
			if (up) {
				angle = 0;
				if (right)
					angle -= 45;
				if (left) {
					angle += 45;
				}
			} else if (down) {
				angle = 180;
				if (right)
					angle += 45;
				if (left)
					angle -= 45;
			} else if (right) {
				angle = 270;
			} else if (left) {
				angle = 90;
			}
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));

		}
		if (!moving) {
			Vector3 mousePos = Input.mousePosition;

			Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
			mousePos.x = mousePos.x - objectPos.x;
			mousePos.y = mousePos.y - objectPos.y;

			float angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;
			angle -= 90;
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));
			mAnim.Play ("PlayerIdle");
		} else {
			mAnim.Play ("PlayerWalk");
		}
				
	}
}
