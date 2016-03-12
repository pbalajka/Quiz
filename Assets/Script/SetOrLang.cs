using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetOrLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageLabelScript.GetOr();
	}
}
