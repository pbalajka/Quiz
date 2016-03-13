using UnityEngine;
using System.Collections;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;
	private static bool wait = false;
	public GameObject answerField;

	public void ShowKeyboard() {
		if (Utils.IsMobil()) {
			keyboard = TouchScreenKeyboard.Open ("Input text", TouchScreenKeyboardType.Default, false, false, false, false);
			ok = true;
		}
	}

    void OnGUI() {		
		if(!Utils.IsMobil())
			return;
		
		if (wait)
			return;
		
		if (keyboard != null && keyboard.done && ok) {
			ok = false;
			string text = keyboard.text;
			char[] textArray = text.ToCharArray();
			answerField.GetComponent<SetCorrectLetter> ().IsLetterCorrect (textArray[0]);
		}
	}

	public static void SetWait(bool waitValue) {
		wait = waitValue;
	}
}