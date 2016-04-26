using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End8 : MonoBehaviour {

	private bool endStartAnimation;


	// Use this for initialization
	void Start () {
		endStartAnimation = false;
	}

	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().color.a == 1 && !endStartAnimation) {
			StartInvokeToEnd ();

		}
		if (GetComponent<Image> ().color.a == 0 && endStartAnimation) {
			EndGame ();
		}
	}

	private void StartInvokeToEnd() {
		Invoke ("ChangeEndStartAnimation", 1);
	}

	private void ChangeEndStartAnimation() {
		endStartAnimation = true;
		EndAnimation ();
	}

	void EndAnimation(){
		GetComponent<Animator> ().Play ("End");
	}

	private void EndGame(){
		if (End6.GetDownButtClick ()) {
			print ("Download");
		} else {
			print ("Prasivec sa porouci ");
			Application.Quit ();
		}
	}
}
