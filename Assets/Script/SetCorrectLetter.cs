using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetCorrectLetter : MonoBehaviour {
	private static Text textField;
	private string answer;
	// Use this for initialization
	void Start () {
		textField = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void SetText(char inputChar) {
		textField.text += inputChar.ToString();
	}

	private void LoadAnswer() {
		switch(ActualSceneNunberScript.SceneNumber ()) {
		case 1:
			answer = LanguageAnswerScritp.Get1Answer();
			break;
		case 2:
			answer = LanguageAnswerScritp.Get2Answer();
			break;
		case 3:
			answer = LanguageAnswerScritp.Get3Answer();
			break;
		case 4:
			answer = LanguageAnswerScritp.Get4Answer();
			break;
		case 5:
			answer = LanguageAnswerScritp.Get5Answer();
			break;
		case 6:
			answer = LanguageAnswerScritp.Get6Answer();
			break;
		case 7:
			answer = LanguageAnswerScritp.Get7Answer();
			break;
		case 8:
			answer = LanguageAnswerScritp.Get8Answer();
			break;
		case 9:
			answer= LanguageAnswerScritp.Get9Answer();
			break;
		case 10:
			answer = LanguageAnswerScritp.Get10Answer();
			break;
		case 11:
			answer = LanguageAnswerScritp.Get11Answer();
			break;
		case 12:
			answer = LanguageAnswerScritp.Get12Answer();
			break;
		}
	
	}
}
