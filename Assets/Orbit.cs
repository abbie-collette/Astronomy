using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Orbit : MonoBehaviour {

	public float rotationalSpeed;

	public float simulationSpeed;

	// Update is called once per frame
	void Update () {
		if (rotationalSpeed != 0) {
			transform.RotateAround (new Vector3 (-45.0f, 0.5f, 0.0f), Vector3.up, ((360 / rotationalSpeed) * simulationSpeed) * Time.deltaTime);
		}
	}
	public void stopOrbit () {
		rotationalSpeed = 0;
	}
}

