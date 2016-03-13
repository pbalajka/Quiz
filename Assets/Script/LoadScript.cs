using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {
	 string sceneLoad;






	public void LoadGame() {
		int guest = PlayerPrefs.GetInt ("question", 0);

		sceneLoad = "question_" + guest.ToString ();

		SceneManager.LoadScene (sceneLoad, LoadSceneMode.Single);

	}




}
