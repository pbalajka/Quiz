﻿using UnityEngine;
using System.Collections;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;
	public GameObject answerField;

	public void ShowKeyboard() {
		if (Utils.IsMobil()) {
			keyboard = TouchScreenKeyboard.Open ("", TouchScreenKeyboardType.Default, false, false, false, false);
			ok = true;
		}
	}

    void OnGUI() {		
		if(!Utils.IsMobil())
			return;
		
		if (keyboard != null && keyboard.done && ok) {
			ok = false;
			string text = keyboard.text;
			char[] textArray = text.ToCharArray();
			answerField.GetComponent<SetCorrectLetter> ().IsLetterCorrect (textArray[0]);
		}
	}
}