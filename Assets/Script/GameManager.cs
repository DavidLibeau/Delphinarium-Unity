using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int score=0;
	public GameObject scoreText;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void incrementScore(int point){
		score += point;
		scoreText.GetComponent<Text>().text="Score : " + score;
	}
}
