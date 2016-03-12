using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {
	public string sceneLoad;




	public void LoadGame() {
		int guest = PlayerPrefs.GetInt ("question", 0);
		sceneLoad = "question_" + guest;
		print ("Vola sa scena cislo"+ guest);
		SceneManager.LoadScene ("sceneLoad", LoadSceneMode.Single);

	}




}
