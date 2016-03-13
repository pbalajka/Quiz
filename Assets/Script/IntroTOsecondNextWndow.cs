using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroTOsecondNextWndow : MonoBehaviour {

	void Start () {
<<<<<<< HEAD
		
		Invoke ("NextLevel", 4);

	}
	
	// Update is called once per frame
	void Update () {

=======
		Invoke ("NextLevel", 0);
>>>>>>> origin/master
	}

	void NextLevel() {
			SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
		}

	}