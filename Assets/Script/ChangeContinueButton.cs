using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeContinueButton : MonoBehaviour {
	
	Text text;
	Button butt;

	// Use this for initialization
	void Start () {
		ChangeInteractebler ();

	}

	void ChangeInteractebler(){
		text =	gameObject.GetComponentsInChildren<Text> () [0];
		print (text.text);

		if (PlayerPrefs.GetInt ("question", 0) == 0) {
			butt = GetComponent<Button> ();
			butt.interactable = false;
			text.color = new Color32 (1, 16, 255, 50);

		} else {
			butt = GetComponent<Button> ();
			butt.interactable = true;
			text.color = new Color32 (1, 16, 255, 255);

		}


	}







}


