﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSaveLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageLabelScript.GetSave ();
	}
}