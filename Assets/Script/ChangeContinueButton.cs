using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeContinueButton : MonoBehaviour {
	Text text;
	Button butt;
	private static bool changedLanguage = false;
	private bool alow;

	// Use this for initialization


	void Start () {
		alow = false;
		ChangeInteractebler ();

	}

	void Update(){
		if(alow)
		PresedContinuButt ();
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
		alow = false;

	}

	private void UnBlockContinue() {
		butt = GetComponent<Button> ();
		butt.interactable = true;
		text.color = new Color32 (1, 16, 255, 255);
		alow = true;
	}

	public static void  SetChangedLanguage(bool changed) {
		changedLanguage = changed;
	}

	void PresedContinuButt(){
		butt = GetComponent<Button> ();
		butt.onClick.AddListener (ChangepressedButt);
	}
	void ChangepressedButt(){
		text.color = new Color32 (255, 255, 255, 255);
	}
}
