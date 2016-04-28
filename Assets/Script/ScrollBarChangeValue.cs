using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScrollBarChangeValue : MonoBehaviour {
	public Scrollbar scrollbar;
	public Text text;
	public Button butt;
	public GameObject waterObj;
	public Color disableColor;

	void Start(){
		disableColor = new Color (1, 16, 255, 50);

	}	


	public void ChangeValue(){
		
		if (scrollbar.value == 0f) {
			Invoke ("ActiveWaterPerson", 1.4f);

		}
		else 
			InactiveWaterPerson ();
			ChangeColorFalse ();
	}


	void ChangeColorTrue(){
		if (scrollbar.value == 0f) {
			butt.interactable = true;
			InactiveWaterPerson ();
		} else
			return;

	}
	void ChangeColorFalse(){
		

		butt.interactable = false;
	


	}

	void ActiveWaterPerson(){
		if (scrollbar.value == 0f) {
			waterObj.SetActive (true);
			Invoke ("ChangeColorTrue", 5);

		}
	}

	void InactiveWaterPerson(){
		waterObj.SetActive (false);

	}
}
