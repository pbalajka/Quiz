using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End5 : MonoBehaviour {

	void Start () {

			Invoke ("NextWin", 1);
		}
		

	void NextWin(){
		SceneManager.LoadScene ("End5,5", LoadSceneMode.Single);
	}

}
