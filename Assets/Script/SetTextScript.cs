using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTextScript : MonoBehaviour {
	private static Text textField;

	void Start() {
		textField = GetComponent<Text> ();
	}

	public static void SetText(char inputChar) {
		textField.text += inputChar.ToString();
	}
}
