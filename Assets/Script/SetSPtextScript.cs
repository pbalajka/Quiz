using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSPtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetEspButton ();

	}
	

}
