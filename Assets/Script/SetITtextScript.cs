﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetITtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetItButton ();

	}

}
