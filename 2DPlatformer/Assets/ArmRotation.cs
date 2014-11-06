﻿using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public int rotationOffset = 90;

	// Update is called once per frame
	void Update () {

		//Substracting the positiion of the player from the mouse position
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position; 		
		difference.Normalize ();			//Normalising the vector : Meaning that all the vector will be equal to 1.

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;			//find the angle in degrees
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);

	}
}
