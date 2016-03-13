using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageAnswerScript : MonoBehaviour {
	private Image image;
	public Sprite[] obrWrong;
	public Sprite[] obrGood;
	private static int currentIndexWrongSprite = 0;
	private static int currentIndexGoodSprite = 0;
	private Color32 transparent = new Color32(255,255,255,0);
	private Color32 noTransparent = new Color32(255,255,255,255);

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
	}
		
	private void ShowWrongImage(){
		if (currentIndexWrongSprite >= obrWrong.Length)
			currentIndexWrongSprite = 0;

		image.sprite = obrWrong [currentIndexWrongSprite];
		currentIndexWrongSprite = ++currentIndexWrongSprite;
	}

	private void ShowGoodImage(){
		if (currentIndexGoodSprite >= obrGood.Length)
			currentIndexGoodSprite = 0;

		image.sprite = obrGood [currentIndexGoodSprite];
		currentIndexGoodSprite = ++currentIndexGoodSprite;
	}

	private void HideImage() {
		image.color = transparent;
		image.raycastTarget = false;
		UnlockKey ();
	}

	private void HideImageAndNextScene(){
		HideImage ();
		UnlockKey ();
		LoadNewScene.NextScene ();
	}

	public void ShowImageWrong() {
		LockKey ();
		ShowWrongImage ();
		image.color = noTransparent;
		image.raycastTarget = true;
		Invoke ("HideImage", 3);
	}

	public void ShowImageGood() {
		LockKey ();
		ShowGoodImage ();
		image.color = noTransparent;
		image.raycastTarget = true;
		Invoke ("HideImageAndNextScene", 3);
	}

	private void LockKey(){
		if(Utils.IsMobil())
			HideShowKeyboard.SetWait (true);
		else
			LoadCharFromKeyboard.SetWait (true);
	}

	private void UnlockKey(){
		if(Utils.IsMobil())
			HideShowKeyboard.SetWait (false);
		else
			LoadCharFromKeyboard.SetWait (false);
	}
}