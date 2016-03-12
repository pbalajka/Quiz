using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextWindowLanguage : MonoBehaviour {

	public void NextWin(){
		SceneManager.LoadScene ("Language", LoadSceneMode.Single);

	}
}
