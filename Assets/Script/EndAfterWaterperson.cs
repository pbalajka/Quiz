using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndAfterWaterperson : MonoBehaviour {

	void Start(){
		InvokationEndGame ();
	}
	public void InvokationEndGame(){
		Invoke ("Ending", 3);
	}

	private void Ending() {
		SceneManager.LoadScene ("End6", LoadSceneMode.Single);

	}
}
