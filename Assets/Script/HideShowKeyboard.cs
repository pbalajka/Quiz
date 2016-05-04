using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;
	private static bool wait = false;
	public GameObject answerField;
	private static bool block = false;

	public void ShowKeyboard() {
		if(!block) {
			if (Utils.IsMobil()) {
				keyboard = TouchScreenKeyboard.Open ("", TouchScreenKeyboardType.Default, false, false, false, false);
				ok = true;
			}
		}
	}

	public static void LockButtonKeybort(){
		block = true;
	}

	public static void UnLockButtonKeybort(){
		block = false;
	}

    void OnGUI() {		
		if(!Utils.IsMobil())
			return;
		
		if (wait)
			return;
		
		if (keyboard != null && keyboard.done && ok) {
			string text = keyboard.text;
			if (answerField.GetComponent<SetCorrectLetter>().IsWordCorrecrt(text)) {

			} else {
				char[] textArray = text.ToCharArray ();
				answerField.GetComponent<SetCorrectLetter> ().IsLetterCorrect (textArray [0]);
			}

			ok = false;
		}
	}

	public static void SetWait(bool waitValue) {
		wait = waitValue;
	}
}