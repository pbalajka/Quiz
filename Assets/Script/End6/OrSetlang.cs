using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OrSetlang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageEnd6Label.GetOr ();

	}
	

}
