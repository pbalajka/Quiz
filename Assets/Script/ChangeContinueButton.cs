using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeContinueButton : MonoBehaviour {


	Button butt;
	// Use this for initialization
	void Start () {
		ChangeInteractebler ();


	}

	// Update is called once per frame
	void Update () {
		
	}

	void ChangeInteractebler(){
		int guest = PlayerPrefs.GetInt ("question", 0);
		if (guest == 0) {
			butt = GetComponent<Button> ();
			butt.interactable = false;

			print ("Neda sa pokracovat");
		} else {
			butt = GetComponent<Button> ();
			butt.interactable = true;

			print ("Mozeme pokracova");
		}


	}



}


