using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name) {
			case "Side1":
				DiceNumberTextScript.diceNumber1 = 6;
				break;
			case "Side2":
				DiceNumberTextScript.diceNumber1 = 5;
				break;
			case "Side3":
				DiceNumberTextScript.diceNumber1 = 4;
				break;
			case "Side4":
				DiceNumberTextScript.diceNumber1 = 3;
				break;
			case "Side5":
				DiceNumberTextScript.diceNumber1 = 2;
				break;
			case "Side6":
				DiceNumberTextScript.diceNumber1 = 1;
				break;
			}
			switch (col.gameObject.name)
			{
				case "Side21":
					DiceNumberTextScript.diceNumber2 = 6;
					break;
				case "Side22":
					DiceNumberTextScript.diceNumber2 = 5;
					break;
				case "Side23":
					DiceNumberTextScript.diceNumber2 = 4;
					break;
				case "Side24":
					DiceNumberTextScript.diceNumber2 = 3;
					break;
				case "Side25":
					DiceNumberTextScript.diceNumber2 = 2;
					break;
				case "Side26":
					DiceNumberTextScript.diceNumber2 = 1;
					break;
			}
			DiceNumberTextScript.diceNumber = DiceNumberTextScript.diceNumber1 + DiceNumberTextScript.diceNumber2;
		}
	}
}
