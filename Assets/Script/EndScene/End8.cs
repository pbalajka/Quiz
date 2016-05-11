using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End8 : MonoBehaviour {

	private bool endStartAnimation;


	// Use this for initialization
	void Start () {
		Invoke ("EndGame", 1);
	}

	private void EndGame(){
		if (End6.GetDownButtClick ()) {
			Application.OpenURL("http://unity3d.com/");
			Application.Quit ();
			Debug.Log ("AkO koncii");
		} else {
			Application.Quit ();
			Debug.Log ("AkO koncii");

		}
	}
}
