using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SetDescriptionText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageDescriptionScript.GetDescription ();
	}
	

}
