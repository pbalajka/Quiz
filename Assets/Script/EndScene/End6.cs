using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End6 : MonoBehaviour {
	private static bool download = false;
	public void ClickButtDown(){
		download = true;
		NextWin ();
	}

	public void ClickButtEnd(){
		download = false;
		NextWin ();
	}

	void NextWin(){
		SceneManager.LoadScene ("End7", LoadSceneMode.Single);
	}


	public static bool GetDownButtClick() {
		return download;
	}
}
