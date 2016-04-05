using UnityEngine;
using System.Collections;

public class SetITtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetItButton ();

	}

}
