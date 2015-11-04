using UnityEngine;
using System.Collections;

var object : Transform;
var clicked = false;

function Click () {
	clicked = true;
}

function Update () {
	if(clicked){
		object.GetComponent(OtherScript).activated = true;
	}
}