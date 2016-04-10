using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Disablebutton : MonoBehaviour {
	Text text;
	Button butt;
	public Scrollbar scrollbar;
	bool down = false;
	public GameObject waterObj;
	void Start(){
		
	}

	void Update(){
		IfSliderDown ();



	}


	//zmeni farbu textu
	public void IfSliderDown(){
		
		if (scrollbar.value == 0f) {
			down = true;
			Invoke ("ActiveWaterPerson", 4);


		} else
			down = false;
		InactiveWaterPerson ();
	}

	void ChangeColorTrue(){
		if (down) {
			text =	gameObject.GetComponentsInChildren<Text> () [0];
			butt = GetComponent<Button> ();
			butt.interactable = true;
			text.color = new Color32 (1, 16, 255, 255);


		}

	}
	void ChangeColorFalse(){
			if (down==false) {
				text =	gameObject.GetComponentsInChildren<Text> () [0];
				butt = GetComponent<Button> ();
				butt.interactable = false;
				text.color = new Color32 (1, 16, 255, 50);
			}
		}

	void InactiveWaterPerson(){
		if(down== false)
		waterObj.SetActive (false);
		ChangeColorFalse ();
	}

	void ActiveWaterPerson(){
		if(down)
		waterObj.SetActive (true);
		Invoke ("ChangeColorTrue", 5);
	}


}
