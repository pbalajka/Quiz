using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BoldTextScript : MonoBehaviour {

	public Text saveText;
	public Text endText;



	public void SetBoldSave(){

		saveText.fontStyle = FontStyle.Bold;
		Invoke ("disableBoldSave", 1);
	}


	public void SetBoldEnd(){

		endText.fontStyle = FontStyle.Bold;
		Invoke ("disableBoldEnd", 1);
	}



	void disableBoldSave(){
		saveText.fontStyle = FontStyle.Normal;
	}

	void disableBoldEnd(){
		endText.fontStyle = FontStyle.Normal;

	}
}
