using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End55 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("NextWin", 3);
	}
	
	void NextWin(){
		SceneManager.LoadScene ("End6", LoadSceneMode.Single);
	}
}
