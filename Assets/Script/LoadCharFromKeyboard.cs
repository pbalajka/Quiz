using UnityEngine;
using System.Collections;

public class LoadCharFromKeyboard : MonoBehaviour {
	public GameObject answerField;
	private static bool wait = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Utils.IsMobil ())
			return;
		
		if (wait)
			return;
		
		foreach(char c in Input.inputString) {
			answerField.GetComponent<SetCorrectLetter> ().IsLetterCorrect (c);
		}
	}

	public static void SetWait(bool waitValue) {
		wait = waitValue;
	}
}