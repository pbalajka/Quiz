using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetContLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageLabelScript.GetContinue ();
	}
	

}
