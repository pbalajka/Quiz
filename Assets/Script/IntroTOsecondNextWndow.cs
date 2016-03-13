using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroTOsecondNextWndow : MonoBehaviour {

	void Start () {

		
		Invoke ("NextLevel", 4);

	}
	


	void NextLevel() {
			SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
		}

	}