﻿using UnityEngine;
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
			currentIndexWrongSprite = 3;

		image.sprite = obrWrong [currentIndexWrongSprite];
		currentIndexWrongSprite = ++currentIndexWrongSprite;
	}

	private void ShowWrongImageOneToSliderShow() {
		image.sprite = obrWrong [0];
		Invoke ("ShowWrongImageTwoToslideShow", 3);
	}

	private void ShowWrongImageTwoToslideShow() {
		image.sprite = obrWrong [1];
		Invoke ("ShowWrongImageThreeToslideShow", 2);
	}

	private void ShowWrongImageThreeToslideShow() {
		image.sprite = obrWrong [2];
		currentIndexWrongSprite = ++currentIndexWrongSprite;
		Invoke ("HideImage", 1);
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
		LockKeyboard.UnlockKey ();
	}

	private void HideImageAndNextScene(){
		HideImage ();
		LockKeyboard.UnlockKey ();
		LoadNewScene.NextScene ();
	}

	public void ShowImageWrongAfterPerson(){
		LockKeyboard.LockKey ();
		if(currentIndexWrongSprite == 0) {
			ShowWrongImageOneToSliderShow ();
			image.color = noTransparent;
			image.raycastTarget = true;
		} else {
			ShowWrongImage ();
			image.color = noTransparent;
			image.raycastTarget = true;
			Invoke ("HideImage", 3);
		}
	}


	public void ShowImageGood() {
		LockKeyboard.LockKey ();
		Invoke ("ShowImageGoodAfterPerson", 4);
	}

	private void ShowImageGoodAfterPerson(){
		LockKeyboard.LockKey ();
		ShowGoodImage ();
		image.color = noTransparent;
		image.raycastTarget = true;
		Invoke ("HideImageAndNextScene", 3);


	}


	public static int GetWrongIndex() {
		return currentIndexWrongSprite;
	}

	public static int GetGoodIndex() {
		return currentIndexGoodSprite;
	}

	public static void SetWrongIndex(int wrongIndex) {
		currentIndexWrongSprite = wrongIndex;
	}

	public static void SetGoodIndex(int goodIndex) {
		currentIndexGoodSprite = goodIndex;
	}
}