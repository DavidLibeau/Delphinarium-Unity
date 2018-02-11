using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControlX : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation = Quaternion.Euler (0, Input.GetAxis ("Mouse X"), 0)*transform.localRotation;
	}
}
