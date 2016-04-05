using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SetENGtextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageScriptButton.GetEngButton ();
	}
	
}
