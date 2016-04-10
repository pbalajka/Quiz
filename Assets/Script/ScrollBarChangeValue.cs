using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScrollBarChangeValue : MonoBehaviour {
	public Scrollbar scrollbar;
	public Text text;
	public Button butt;
	public GameObject waterObj;


	void Start(){
		

	}	


	public void ChangeValue(){
		
		if (scrollbar.value == 0f) {
			Invoke ("ActiveWaterPerson", 4);

		}
		else 
			InactiveWaterPerson ();
			ChangeColorFalse ();
	}


	void ChangeColorTrue(){
		if (scrollbar.value == 0f) {
			butt.interactable = true;
			text.color = new Color32 (1, 16, 255, 255);
			InactiveWaterPerson ();
		} else
			return;

	}
	void ChangeColorFalse(){
		

		butt.interactable = false;
		text.color = new Color32 (1, 16, 255, 50);

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
