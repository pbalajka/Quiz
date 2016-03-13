using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

	public static void NextScene() {
		string question = "question_";
		int actualScene = ActualSceneNunberScript.SceneNumber();
		actualScene = ++actualScene;
		string scene = question + actualScene.ToString ();
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}
}