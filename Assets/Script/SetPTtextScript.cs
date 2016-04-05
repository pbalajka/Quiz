using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetPTtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetPtButton ();

	}
	

}
