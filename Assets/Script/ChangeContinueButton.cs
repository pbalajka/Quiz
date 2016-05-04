using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeContinueButton : MonoBehaviour {
	Text text;
	Button butt;
	private static bool changedLanguage = false;

	// Use this for initialization
	void Start () {
		ChangeInteractebler ();
	}
		
	void ChangeInteractebler(){
		text =	gameObject.GetComponentsInChildren<Text> () [0];
	
		if (PlayerPrefs.GetInt ("question", 0) != 0 && !changedLanguage) {
			UnBlockContinue ();
		} else {
			BlockContinue ();
		}
	}


	private void BlockContinue() {
		butt = GetComponent<Button> ();
		butt.interactable = false;
		text.color = new Color32 (1, 16, 255, 50);
	}

	private void UnBlockContinue() {
		butt = GetComponent<Button> ();
		butt.interactable = true;
		text.color = new Color32 (1, 16, 255, 255);
	}

	public static void  SetChangedLanguage(bool changed) {
		changedLanguage = changed;
	}
}
