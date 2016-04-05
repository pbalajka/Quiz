using UnityEngine;
using System.Collections;

public class SetSPtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetEspButton ();

	}
	

}
