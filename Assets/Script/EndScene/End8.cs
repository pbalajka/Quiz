using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End8 : MonoBehaviour {

	private bool endStartAnimation;

	// Use this for initialization
	void Start () {
		Application.runInBackground = true;
		Invoke ("EndGame", 1);
	}

	private void EndGame(){
		if (End6.GetDownButtClick ()) {
			Application.OpenURL("https://play.google.com/store/apps/developer?id=eshopesource");
			Invoke ("QuitGame", 1);
	

		} else {
			Application.Quit ();
			Debug.Log ("AkO koncii");

		}
	}

	private void QuitGame(){
		Application.Quit ();
	}
}
