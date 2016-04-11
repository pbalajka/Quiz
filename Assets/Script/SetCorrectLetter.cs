using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetCorrectLetter : MonoBehaviour {
	private static Text textField;
	private string answer = "";
	private char underscoreSymbol = '_';
	public  GameObject answerImage;
	public  GameObject afterGoodWord;
	private int correctAnswer = 0;
	// Use this for initialization
	void Start () {
		textField = GetComponent<Text> ();
		answer = LanguageAnswerScritp.GetAnswer (ActualSceneNunberScript.SceneNumber ());
		SetUnderscore ();
	}

	private void SetUnderscore() {
		int count = answer.Length;

		if (count == 0)
			return;
		
		string underscoreAnswer = "";
		for (int i = 0; i < count; i++) {
			underscoreAnswer += underscoreSymbol.ToString() + " ";
		}
		if (underscoreAnswer.Length > 0)
			underscoreAnswer = underscoreAnswer.Remove (underscoreAnswer.Length - 1);
		
		textField.text = underscoreAnswer;
	}

	public void IsLetterCorrect(char inputChar) {
		if (!answer.Contains (inputChar.ToString ())) {
			answerImage.GetComponent<SmileScript> ().ShowBadSmile ();
		} else {
			answerImage.GetComponent<SmileScript> ().ShowGoodSmile ();
		}

		string newTextField = "";
		char[] oldTextField = textField.text.ToCharArray();
		char[] charAnswer = answer.ToCharArray ();
		for (int i = 0; i < answer.Length; i++) {
			if (inputChar == charAnswer [i]) {
				newTextField += charAnswer [i].ToString () + " ";
				correctAnswer += 1;
			} else {
				if (oldTextField [i * 2] == underscoreSymbol)
					newTextField += underscoreSymbol.ToString () + " ";
				else
					newTextField += oldTextField [i * 2].ToString() + " "; 
			}
		}

		newTextField = newTextField.Remove (newTextField.Length - 1);
		textField.text = newTextField;

		CheckEndAnswer ();
	}

	private void CheckEndAnswer() {
		if (correctAnswer == answer.Length) {
			afterGoodWord.GetComponent<ImageAnswerScript> ().ShowImageGood ();
		}
	}
}