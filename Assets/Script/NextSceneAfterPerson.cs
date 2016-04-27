using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextSceneAfterPerson : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Invoke ("NextScene", 2);
	}
	
	private void NextScene(){
		string question = "question_";
		string scene;
		scene = question + LoadNewScene.GetNextSceneNUmber().ToString();
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}
}
