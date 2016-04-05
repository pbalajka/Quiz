using UnityEngine;
using System.Collections;

public class SetRUtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetRuButton ();

	}
	

}
