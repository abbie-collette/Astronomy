using UnityEngine;
using System.Collections;

public class ClickManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Hal wrote this. We understaind it.
		if ( Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray raymond = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (raymond, out hit))
			{  
				GameObject hitObj = hit.collider.gameObject;
				Click clickScript = hitObj.GetComponent<Click>();
				if(clickScript != null) {
					clickScript.OnClick();
					GetComponent<MovementManager>().OnClick();
				}

			}
		}
	}
}
