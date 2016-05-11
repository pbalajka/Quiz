using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetCorrectLetter : MonoBehaviour {
	private static Text textField;
	private string answer = "";
	private string originalAnswer;
	private char underscoreSymbol = '_';
	public  GameObject answerImage;
	public  GameObject afterGoodWord;
	private static int correctAnswer = 0;
	private static string noLoaded = "nothing_to_do";
	private static string loadedAnswer = noLoaded;
	private static int answerLenght = 0;

	// Use this for initialization
	void Start () {
		textField = GetComponent<Text> ();
		correctAnswer = 0;
		answer = LanguageAnswerScritp.GetAnswer (ActualSceneNunberScript.SceneNumber ());
		originalAnswer = answer;
		answerLenght = answer.Length;
		SetUnderscore ();
		ChangeAnswer ();

		if (loadedAnswer != noLoaded) {
			LoadAnswer ();
		}

		LockKeyboard.UnlockKey ();
	}

	private void SetUnderscore() {
		int count = answer.Length;

		if (count == 0)
			return;

		char[] answerArray = answer.ToCharArray ();
		string underscoreAnswer = "";
		for (int i = 0; i < count; i++) {
			if(answerArray[i] == ' ') {
				underscoreAnswer +=  " ";
				answerLenght -= 1;
			} else {
				underscoreAnswer += underscoreSymbol.ToString() + " ";
			}
		}
		if (underscoreAnswer.Length > 0)
			underscoreAnswer = underscoreAnswer.Remove (underscoreAnswer.Length - 1);
		
		textField.text = underscoreAnswer;
	}

	private void ChangeAnswer() {
		char[] charAnswer = answer.ToCharArray ();
		string newAnswer = "";
		for (int i = 0; i < charAnswer.Length; i++) {
			if (charAnswer [i] == ' ') {
				newAnswer += charAnswer [i].ToString ();
			} else {
				newAnswer += charAnswer [i].ToString() + " ";
			}

		}

		answer = newAnswer.Remove (newAnswer.Length - 1);
		print ("|" + answer + "|");
	}

	public void IsLetterCorrect(char inputChar) {
		if (inputChar == ' ')
			return;
		
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
				newTextField += charAnswer [i].ToString ();
				correctAnswer += 1;
			} else {
				if (oldTextField [i] == underscoreSymbol)
					newTextField += underscoreSymbol.ToString ();
				else
					newTextField += oldTextField [i].ToString() ; 
			}
		}
			
		textField.text = newTextField;

		CheckEndAnswer ();
	}

	public bool IsWordCorrecrt(string word) {
		if(originalAnswer == word) {
			SetAnswerToTextField ();
			return true;
		} else {
			return false;
		}
	}

	private void SetAnswerToTextField() {
		
		/*string newTextField = "";
		char[] charAnswer = answer.ToCharArray ();

		for(int i = 0; i < answer.Length; i++) {
			newTextField += charAnswer [i] + " ";
		}
		newTextField = newTextField.Remove (newTextField.Length - 1);
		textField.text = newTextField;
		correctAnswer = answer.Length;
		CheckEndAnswer ();*/

		textField.text = answer;
		correctAnswer = answerLenght;
		CheckEndAnswer ();
	}

	private void CheckEndAnswer() {
		print (correctAnswer + " " + answerLenght);
		if (correctAnswer == answerLenght) {
			LockKeyboard.LockKey ();
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

	public static bool IsAllWorndCorrect() {
		return correctAnswer == answerLenght;
	}
}