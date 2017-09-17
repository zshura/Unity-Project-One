using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCommand : MonoBehaviour {

	float time;
	int myScore;
	bool printedMessage;

	// Use this for initialization
	void Start () {
		print ("the game has begun!");

		printedMessage = false;
	}


	// Update is called once per frame
	void Update () {


		if (Time.time > 3 && printedMessage == false){
			print("it has been three seconds!");
			printedMessage = true;
		}
	}
}
