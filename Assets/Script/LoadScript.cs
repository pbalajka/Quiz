using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {

	public void LoadGame() {
		//Load scene
		int guest = PlayerPrefs.GetInt ("question", 0);
		string sceneLoad = "question_" + guest.ToString ();
		SceneManager.LoadScene (sceneLoad, LoadSceneMode.Single);
		//Load wrong answer
		int wrongIndex = PlayerPrefs.GetInt ("wrongIndex", 0);
		ImageAnswerScript.SetWrongIndex (wrongIndex);
		//Load good answer
		int goodIndex = PlayerPrefs.GetInt ("goodIndex", 0);
		ImageAnswerScript.SetGoodIndex (goodIndex);
	}
}