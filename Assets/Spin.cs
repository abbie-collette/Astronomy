using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
    public float Speed;
	float simSpeed = .2f;
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, ((360/Speed)*simSpeed) * Time.deltaTime, 0);
    } 
}
