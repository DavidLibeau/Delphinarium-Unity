using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrelManager : MonoBehaviour {

	private float distance;
	public GameObject perso;
	private Renderer rend;
	public Material material;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find ("Standard");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (gameObject.transform.position, perso.transform.position);
		material.color = new Color(1, 0, 0, distance/200);
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.name=="Perso") {
			SceneManager.LoadScene ("3_End");
		}
	}
}
