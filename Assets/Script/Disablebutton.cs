using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Disablebutton : MonoBehaviour {
	Text text;
	Button butt;
	public Scrollbar scrollbar;
 

	void Update(){
		ChangeTextToTransparent ();


	}


	//zmeni farbu textu
	public void ChangeTextToTransparent(){
		
		if (scrollbar.value == 0f) {
			text =	gameObject.GetComponentsInChildren<Text> () [0];
			butt = GetComponent<Button> ();
			butt.interactable = true;
			text.color = new Color32 (1, 16, 255, 255);
		}




	}
}
