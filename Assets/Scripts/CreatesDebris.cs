using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatesDebris : MonoBehaviour {
	public int minDebris;
	public int maxDebris;
	public int debrisLife;

	[SerializeField]
	public GameObject[] debris;

	public void generateDebris(){
		int debrisCount = Random.Range (minDebris, maxDebris);
		for (int i = 0; i <= debrisCount; i++) {
			GameObject chosenOne = debris[Random.Range(0,debris.Length)];
			GameObject createdDebris = Instantiate (chosenOne, transform.position, Quaternion.identity);
			Destroy (createdDebris, debrisLife);
		}

	}
}
