using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script na prvej scene, prepnutie na druhu scenu
public class NextWindow : MonoBehaviour {

	public void NextWin(){
		Invoke ("OpenDescription",1);
	}

	private void OpenDescription(){
		SceneManager.LoadScene ("Description", LoadSceneMode.Single);
	}
}