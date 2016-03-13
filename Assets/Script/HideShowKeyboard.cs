using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HideShowKeyboard : MonoBehaviour {
	private TouchScreenKeyboard keyboard;
	private bool ok = false;

	public void ShowKeyboard() {
		keyboard = TouchScreenKeyboard.Open ("Input char", TouchScreenKeyboardType.Default, false, false, false, false);
		ok = true;
	;
	}

    void OnGUI() {		
		if(!Utils.IsMobil())
			return;
		
		if (keyboard != null && keyboard.done && ok) {
			ok = false;
			string text = keyboard.text;
			char[] textArray = text.ToCharArray();
			SetTextScript.SetText(textArray[0]);
		}
	}

	/*void NextScene() {
		string question = "question_";
		int actualScene = ActualSceneNunberScript.SceneNumber();
		actualScene = ++actualScene;
		string scene = question + actualScene.ToString ();
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}*/
}