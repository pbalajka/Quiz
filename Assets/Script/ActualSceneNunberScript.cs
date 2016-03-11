using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ActualSceneNunberScript : MonoBehaviour {

	public static int SceneNumber() {
		string currentScene = SceneManager.GetActiveScene ().name;
		currentScene = currentScene.Substring(currentScene.IndexOf("_") + 1);
		return int.Parse (currentScene);
	}
}