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

	void Start() {
		image = GetComponent<Image> ();
	}

	public void ShowGoodSmile() {
		if (currIndexGoodText >= 5)
			currIndexGoodText = 0;

		text.text = LanguageForSmile.GetGoodAnswer (currIndexGoodText);
		ShowGoodSmileImage ();
		currIndexGoodText = ++currIndexGoodText;
		Invoke ("HideSmile", 4);
	}

	public void ShowBadSmile() {
		if (currIndexGoodText >= 5)
			currIndexGoodText = 0;

		text.text = LanguageForSmile.GetGoodAnswer (currIndexBadText);
		ShowBadSmileImage ();
		currIndexGoodText = ++currIndexGoodText; 
		Invoke ("ShowBadPicture", 4);
	}

	private void ShowGoodSmileImage() {
		image.sprite = goodSmile;
		gameObject.SetActive(true);
	}

	private void ShowBadSmileImage() {
		image.sprite = badSmile;
		gameObject.SetActive(true);
	}

	private void HideSmile() {
		gameObject.SetActive (false);
	}

	private void ShowBadPicture() {
		imageAfterAnswer.GetComponent<ImageAnswerScript> ().ShowImageWrongAfterPerson ();
		HideSmile ();
	}
}