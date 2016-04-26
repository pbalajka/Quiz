using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End6 : MonoBehaviour {
	private static bool download = false;
	private bool endStartAnimation;
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().color.a == 0 && endStartAnimation) {
			NextWin ();
		}
	}

	public void ClickButtDown(){
		download = true;
		endStartAnimation = true;
		EndAnimation ();
	
	}

	public void ClickButtEnd(){
		EndAnimation ();
		download = false;
		endStartAnimation = true;
		
	}

	void NextWin(){
		SceneManager.LoadScene ("End7", LoadSceneMode.Single);
	}

	void EndAnimation(){
		GetComponent<Animator> ().Play ("End");
	}

	public static bool GetDownButtClick() {
		return download;
	}
}
