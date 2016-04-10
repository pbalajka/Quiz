using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ChangeColorLanguageSettings : MonoBehaviour {
	public Text text;
	// Use this for initialization
	public void ChangeCollor () {
		text.color = new Color32 (2, 254, 2, 255);
	}

	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
}
