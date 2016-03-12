using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script na prvej scene, prepnutie na druhu scenu
public class NextWindow : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NextWin(){
		SceneManager.LoadScene ("question_1", LoadSceneMode.Single);
	}
}