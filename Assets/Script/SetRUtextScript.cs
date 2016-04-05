using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetRUtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetRuButton ();

	}
	

}
