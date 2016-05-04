using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class End1 : MonoBehaviour {
	
	//4 sekundy tato scena

	// Use this for initialization
	void Start () {
		Invoke ("NextWin",4);
	
	}


	void NextWin(){
		SceneManager.LoadScene ("End2", LoadSceneMode.Single);
	}
		
}
