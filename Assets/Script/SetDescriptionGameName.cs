using UnityEngine;
using System.Collections;

using UnityEngine.UI;
public class SetDescriptionGameName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageForDescriptionGameName.GetGameName();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
