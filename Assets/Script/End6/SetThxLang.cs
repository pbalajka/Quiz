using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SetThxLang : MonoBehaviour {

	void Start () {
		GetComponent<Text> ().text = LanguageEnd6Label.GetThx ();

	}
}
