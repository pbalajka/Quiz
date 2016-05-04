using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End4 : MonoBehaviour {
// Use this for initialization
	void Start () {


			Invoke ("NextWin", 1);
		}
		
	void NextWin(){
		SceneManager.LoadScene ("End5", LoadSceneMode.Single);
	}


}
