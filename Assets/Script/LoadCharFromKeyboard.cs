using UnityEngine;
using System.Collections;

public class LoadCharFromKeyboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Utils.IsMobil ())
			return;
		
		foreach(char c in Input.inputString) {
			print (c);
		}
	}
}
