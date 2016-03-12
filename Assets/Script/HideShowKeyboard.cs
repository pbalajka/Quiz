using UnityEngine;
using System.Collections;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;

	public void ShowKeyboard() {
		keyboard = TouchScreenKeyboard.Open ("Input char", TouchScreenKeyboardType.Default, false, false, false, false);
		ok = true;
	}

     void OnGUI() {		
		if (keyboard != null && keyboard.done && ok) {
			ok = false;
			string text = keyboard.text;
			char[] textArray = text.ToCharArray();
			SetTextScript.SetText(textArray[0]);
		}
	}
}