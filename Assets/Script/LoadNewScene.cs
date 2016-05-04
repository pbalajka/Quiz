using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {
	private static int actualScene;

	public static void NextScene() {
		string question = "question_";
		int actualSceneTemp = ActualSceneNunberScript.SceneNumber();
		actualSceneTemp = ++actualSceneTemp;
		actualScene = actualSceneTemp;
		string scene;

		if (actualSceneTemp == 4 || actualSceneTemp == 7 || actualSceneTemp == 10) {
			scene = "End1";
			//scene = "WaterPersonScene";
		} else if (actualSceneTemp != 13) {
			scene = question + actualSceneTemp.ToString ();
		} else {
			scene = "End1";
		}
			
		SceneManager.LoadScene (scene, LoadSceneMode.Single);

	
	
	}
	public static int GetNextSceneNUmber(){
		return actualScene;
	}
}