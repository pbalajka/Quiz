﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class End1 : MonoBehaviour {
	private bool endStartAnimation;
	private Animator endAnimationControler;

	// Use this for initialization
	void Start () {
		endStartAnimation = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().color.a == 1 && !endStartAnimation) {
			endStartAnimation = true;
			Invoke ("EndAnimation", 4);
		}
		if (GetComponent<Image> ().color.a == 0 && endStartAnimation) {
			
			NextWin ();
		}
	
	}

	void NextWin(){
		SceneManager.LoadScene ("End2", LoadSceneMode.Single);
	}


	void EndAnimation(){
		//GetComponent<Animator> ().runtimeAnimatorController = 
	}
}
