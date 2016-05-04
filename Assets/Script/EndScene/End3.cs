using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End3 : MonoBehaviour {

	private bool endStartAnimation;


	// Use this for initialization
	void Start () {


		Invoke ("NextWin", 1);
	}

	void NextWin(){
		SceneManager.LoadScene ("End4", LoadSceneMode.Single);
	}


}
