using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End2 : MonoBehaviour {

	private bool endStartAnimation;


	// Use this for initialization
	void Start () {
		Invoke ("NextWin", 2);

	}
		

	void NextWin(){
		SceneManager.LoadScene ("End3", LoadSceneMode.Single);
	}


}
