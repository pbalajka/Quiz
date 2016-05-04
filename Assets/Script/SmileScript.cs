using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SmileScript : MonoBehaviour {
	public Sprite goodSmile;
	public Sprite badSmile;
	public Image imageAfterAnswer;
	public Text text;
	private Image image;
	private static int currIndexGoodText = 0;
	private static int currIndexBadText = 6;


	public void ShowGoodSmile() {
		if (currIndexGoodText >= LanguageForSmile.GetCountGoodAnswer())
			currIndexGoodText = 0;

		text.text = LanguageForSmile.GetGoodAnswer (currIndexGoodText);
		ShowGoodSmileImage ();
		currIndexGoodText = ++currIndexGoodText;
		Invoke ("HideGoodSmile", 4);
	}

	public void ShowBadSmile() {
		if (currIndexBadText >= LanguageForSmile.GetCountBadAnswer())
			currIndexBadText = 0;

		print ("Maximalne cislo zleho smajlika : " + LanguageForSmile.GetCountBadAnswer());
		print ("Aktualne cislo zleho smajlika : " + currIndexBadText);
		text.text = LanguageForSmile.GetBadAnswer (currIndexBadText);
		ShowBadSmileImage ();
		currIndexGoodText = ++currIndexBadText; 
		Invoke ("ShowBadPicture", 4);
	}

	private void ShowGoodSmileImage() {
		LockKeyboard.LockKey ();
		ShowImage ();
		GetComponent<Image> ().sprite = goodSmile;
	}

	private void ShowBadSmileImage() {
		LockKeyboard.LockKey ();
		ShowImage ();
		GetComponent<Image> ().sprite = badSmile;
	}

	private void HideGoodSmile() {
		LockKeyboard.UnlockKey ();
		gameObject.SetActive (false);
	}

	private void HideBadSmile() {
		gameObject.SetActive (false);
	}

	private void ShowImage() {
		gameObject.SetActive(true);
	}
	private void ShowBadPicture() {
		imageAfterAnswer.GetComponent<ImageAnswerScript> ().ShowImageWrongAfterPerson ();
		HideBadSmile ();
	}
}