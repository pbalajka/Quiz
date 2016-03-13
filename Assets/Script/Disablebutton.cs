using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Disablebutton : MonoBehaviour {
	Text text;
	Button butt;

	void Start(){
		Invoke ("ChangeTextToTransparent", 5);
	}


	//zmeni farbu textu
	public void ChangeTextToTransparent(){
		
			text =	gameObject.GetComponentsInChildren<Text> () [0];
			butt = GetComponent<Button> ();
			butt.interactable = true;
			text.color = new Color32 (1, 16, 255, 255);


	}
}
