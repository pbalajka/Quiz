using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script na prvej scene, prepnutie na druhu scenu
public class NextWindow : MonoBehaviour {

	public void NextWin(){
		SceneManager.LoadScene ("Description", LoadSceneMode.Single);
		print ("invoke Description");
	}
}