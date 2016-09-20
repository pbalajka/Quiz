using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetDownLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageEnd6Label.GetDownload ();
	}
	

}
