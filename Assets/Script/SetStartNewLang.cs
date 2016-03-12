using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SetStartNewLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageLabelScript.GetNewGame ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
