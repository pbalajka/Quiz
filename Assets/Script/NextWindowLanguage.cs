using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextWindowLanguage : MonoBehaviour {

	public void NextWin(){
		SceneManager.LoadScene ("screen3", LoadSceneMode.Single);

	}
}
