/*using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
     
	public float rotationalSpeed;

	float simulationSpeed = 70;

	// Update is called once per frame
	void Update () {
		transform.RotateAround (new Vector3(-45.0f, 0.5f, 0.0f), Vector3.up, ((360/rotationalSpeed)*simulationSpeed) * Time.deltaTime);
		
	}
}