using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour {



	public void NextWin(){
		SceneManager.LoadScene ("question_1", LoadSceneMode.Single);
	}
}
