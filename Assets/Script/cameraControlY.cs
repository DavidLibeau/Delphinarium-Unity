using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraControlY : MonoBehaviour {

	public GameObject perso;

	private float speedUp;
	private float speed=1;

	public GameObject speedImg;
	public AudioSource music;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.localRotation.x<=0.5 && transform.localRotation.x>=-0.5) {
			transform.localRotation = Quaternion.Euler (-Input.GetAxis ("Mouse Y")*1.5f, 0, 0)*transform.localRotation;
		} else {
			//rotationX=0;
			if (transform.localRotation.x > 0.5) {
				transform.localRotation = Quaternion.Euler (-0.1f,0f,0f)* transform.localRotation;
			}
			if (transform.localRotation.x<-0.5) {
				transform.localRotation = Quaternion.Euler (0.1f,0f,0f)*transform.localRotation;
			}
		}

		speedUp = -transform.localRotation.x * 0.5f;

		perso.transform.Translate(0, speedUp, 0.05f*speed);


		if (Input.GetKeyDown (KeyCode.Space)) {
			speed = 30;
		}
		if (speed > 1) {
			speed -= 0.2f;
		} else {
			speed = 10;
		}
		speedImg.GetComponent<RawImage>().color = new Color(0f, 0f, 0f, (speed-10)/30f);
		speedImg.GetComponent<RectTransform>().sizeDelta = new Vector2((8/(speed - 9f))*1000, (8/(speed - 9f))*1000);

		music.volume = (speed - 10) / 30;
	}
}
