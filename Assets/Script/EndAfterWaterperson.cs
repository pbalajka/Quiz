using UnityEngine;
using System.Collections;

public class EndAfterWaterperson : MonoBehaviour {

	void Start(){
		InvokationEndGame ();
	}
	private void InvokationEndGame(){
		Invoke ("EndGame", 3);
	}

	private void EndGame() {
		Application.Quit ();
		Debug.Log("KOniec aplikacie");
	}
}
