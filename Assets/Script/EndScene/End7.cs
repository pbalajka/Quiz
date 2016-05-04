using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class End7 : MonoBehaviour {

	void Start () {

			Invoke ("NextWin", 1.5f);
		}
		

	void NextWin(){
		SceneManager.LoadScene ("End8", LoadSceneMode.Single);
	}


}
