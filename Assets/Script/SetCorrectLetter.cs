using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetCorrectLetter : MonoBehaviour {
	private static Text textField;
	private string answer = "";
	private char underscoreSymbol = '_';
	public  GameObject answerImage;
	public  GameObject afterGoodWord;
	private static int correctAnswer = 0;
	private static string noLoaded = "nothing_to_do";
	private static string loadedAnswer = noLoaded;
	// Use this for initialization
	void Start () {
		textField = GetComponent<Text> ();
		correctAnswer = 0;
		answer = LanguageAnswerScritp.GetAnswer (ActualSceneNunberScript.SceneNumber ());
		SetUnderscore ();
		if (loadedAnswer != noLoaded) {
			LoadAnswer ();
		}
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
		if (textField.text.Contains (inputChar.ToString()))
			return;
		
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

		print (" Dlzka odpovede: " + answer.Length);
		print (" Aktualne spravnych: " + correctAnswer);

		CheckEndAnswer ();
	}

	public bool IsWordCorrecrt(string word) {
		if(answer == word) {
			SetAnswerToTextField ();
			return true;
		} else {
			return false;
		}
	}

	private void SetAnswerToTextField() {
		string newTextField = "";
		char[] charAnswer = answer.ToCharArray ();

		for(int i = 0; i < answer.Length; i++) {
			newTextField += charAnswer [i] + " ";
		}
		newTextField = newTextField.Remove (newTextField.Length - 1);
		textField.text = newTextField;
		correctAnswer = answer.Length;
		CheckEndAnswer ();
	}

	private void CheckEndAnswer() {
		if (correctAnswer == answer.Length) {
			Invoke ("ShowGoodImageAndNextScene", 3);
		}
	}

	private void ShowGoodImageAndNextScene() {
		afterGoodWord.GetComponent<ImageAnswerScript> ().ShowImageGood ();
	}

	public static string GetActualAnswer() {
		return textField.text;
	}

	private void LoadAnswer() {
		char[] loadedAnswerCharArray = loadedAnswer.ToCharArray ();
		for (int i = 0; i < loadedAnswer.Length; i++) {
			if (loadedAnswerCharArray [i] != ' ' && loadedAnswerCharArray [i] != '_')
				correctAnswer += 1;
		}

		textField.text = loadedAnswer;
		loadedAnswer = noLoaded;
	}

	public static void SetLoadedAnswer(string loadedAns) {
		loadedAnswer = loadedAns;
	}
}