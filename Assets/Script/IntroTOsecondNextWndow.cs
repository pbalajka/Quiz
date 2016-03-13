using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroTOsecondNextWndow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Invoke ("NextLevel", 4);

	}
	
	// Update is called once per frame
	void Update () {

	}


	void NextLevel() {
			SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
		}

	}

