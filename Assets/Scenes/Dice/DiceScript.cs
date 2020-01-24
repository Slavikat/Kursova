using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;

	public static bool roll;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		diceVelocity = rb.velocity;

		if (roll) {
			DiceNumberTextScript.diceNumber = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);

			
					transform.position = new Vector3(15.780f, 2.79f, 14.54f);
					
			
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500);
			rb.AddTorque (dirX, dirY, dirZ);
			roll = !roll;
		}
	}
}
