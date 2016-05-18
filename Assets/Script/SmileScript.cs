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
	private static int currIndexBadText = 0;
	public Button save;
	public Button exit;

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

		text.text = LanguageForSmile.GetBadAnswer (currIndexBadText);
		ShowBadSmileImage ();
		currIndexGoodText = ++currIndexBadText; 
		Invoke ("ShowBadPicture", 4);
	}

	private void ShowGoodSmileImage() {
		LockKeyboard.LockKey ();
		LockButt ();
		ShowImage ();
		GetComponent<Image> ().sprite = goodSmile;
	}

	private void ShowBadSmileImage() {
		LockKeyboard.LockKey ();
		LockButt ();
		ShowImage ();
		GetComponent<Image> ().sprite = badSmile;
	}

	private void HideGoodSmile() {
		if (!SetCorrectLetter.IsAllWorndCorrect ()) {
			LockKeyboard.UnlockKey ();
			UnLockButt ();
		}

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
		UnLockButt ();
	}


	private void LockButt(){
		save.interactable = false;
		exit.interactable = false;
	}
	private void UnLockButt(){
		save.interactable = true;
		exit.interactable = true;
	}
}