using UnityEngine;
using System.Collections;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;
	private static bool wait = false;
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