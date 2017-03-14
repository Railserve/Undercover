using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOverTime : MonoBehaviour {
	// Literally just a script to make an object move a direction at a speed.  Because I needed it to make Roger and Tim do the Titanic thing on the Leaf because I was
	// Too lazy to set up Cinema Director just for that 3 seconds of clippage.  Sue me.
	
	public Vector3 velocity;
	public bool rotationInstead;
	
	void Update () {
		if (rotationInstead)
			transform.localEulerAngles += velocity * Time.deltaTime;
		else
			transform.position += velocity * Time.deltaTime;
	}
	
	void OnDrawGizmos () {
		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, transform.position + velocity);
	}
}
