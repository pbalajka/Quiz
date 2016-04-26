using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End2 : MonoBehaviour {

	private bool endStartAnimation;


	// Use this for initialization
	void Start () {
		endStartAnimation = false;

	}

	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().color.a == 1 && !endStartAnimation) {
			endStartAnimation = true;
			Invoke ("EndAnimation", 2);
		}
		if (GetComponent<Image> ().color.a == 0 && endStartAnimation) {

			NextWin ();
		}

	}

	void NextWin(){
		SceneManager.LoadScene ("End3", LoadSceneMode.Single);
	}


	void EndAnimation(){
		GetComponent<Animator> ().Play ("End");
	}
}
