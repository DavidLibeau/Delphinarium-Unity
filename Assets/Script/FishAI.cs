using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAI : MonoBehaviour {

	private float speed;

	private GameManager gm;

	// Use this for initialization
	void Start () {
		gm = FindObjectOfType<GameManager> ();
		speed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation = Quaternion.Euler (0f,Random.Range(-5f, 5f),0f)*transform.localRotation;
		transform.Translate(Random.Range(0f, 0.1f)*speed, Random.Range(-0.05f, 0.05f), 0);
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Perso") {
			gm.incrementScore (1);
		}
		Destroy(gameObject);
	}
}
