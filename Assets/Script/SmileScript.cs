using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SmileScript : MonoBehaviour {
	public Sprite goodSmile;
	public Sprite badSmile;
	public Image imageAfterAnswer;
	public Text text;
	private Image image;
	private static int currIndexGoodText = 1;
	private static int currIndexBadText = 1;


	public void ShowGoodSmile() {
		if (currIndexGoodText >= LanguageForSmile.GetCountGoodAnswer())
			currIndexGoodText = 0;

		text.text = LanguageForSmile.GetGoodAnswer (currIndexGoodText);
		ShowGoodSmileImage ();
		currIndexGoodText = ++currIndexGoodText;
		Invoke ("HideSmile", 4);
	}

	public void ShowBadSmile() {
		if (currIndexGoodText >= LanguageForSmile.GetCountBadAnswer())
			currIndexGoodText = 0;

		text.text = LanguageForSmile.GetBadAnswer (currIndexBadText);
		ShowBadSmileImage ();
		currIndexGoodText = ++currIndexBadText; 
		Invoke ("ShowBadPicture", 4);
	}

	private void ShowGoodSmileImage() {
		ShowImage ();
		GetComponent<Image> ().sprite = goodSmile;
	}

	private void ShowBadSmileImage() {
		ShowImage ();
		GetComponent<Image> ().sprite = badSmile;
	}

	private void HideSmile() {
		gameObject.SetActive (false);
	}

	private void ShowImage() {
		gameObject.SetActive(true);
	}
	private void ShowBadPicture() {
		imageAfterAnswer.GetComponent<ImageAnswerScript> ().ShowImageWrongAfterPerson ();
		HideSmile ();
	}
}