using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementManager : MonoBehaviour {
	public List<GameObject> planetList = new List<GameObject> ();

		// Update is called once per frame
	public void OnClick () {


		foreach (GameObject planet in planetList) {
			Spin spinScript = planet.GetComponent<Spin> ();
			Orbit orbitScript = planet.GetComponent<Orbit> ();
			if (spinScript != null) {
				spinScript.stop ();
			}
			if (orbitScript != null) {
				orbitScript.stopOrbit ();
			}
		}
	}
}
