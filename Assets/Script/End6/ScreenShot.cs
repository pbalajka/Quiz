using UnityEngine;
using System.Collections;

public class ScreenShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Application.CaptureScreenshot("Screenshot.png");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
