using UnityEngine;
using System.Collections;

public class SetPTtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetPtButton ();

	}
	

}
