using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	bool clicked = false;
	public GameObject see;

	public void OnClick () {
		clicked = true;
	}

	void Update () {
		if(clicked == true){

			Spin spinScript = GetComponent<Spin>();
			if(spinScript != null) {

				spinScript.stop();
			}
			Orbit orbitScript = GetComponent<Orbit>();
			if(orbitScript != null){
			
				orbitScript.stopOrbit();
			}

			Camera.main.transform.position = see.transform.position;
			Camera.main.transform.rotation = see.transform.rotation;

		}
	}

}