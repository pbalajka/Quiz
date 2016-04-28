using UnityEngine;
using System.Collections;

public class EndAfterWaterperson : MonoBehaviour {

	void Start(){
		InvokationEndGame ();
	}
	public void InvokationEndGame(){
		Invoke ("EndGameQuiz", 3);
	}

	private void EndGameQuiz() {
		Application.Quit ();
		Debug.Log("KOniec aplikacie po stlaceni END");
	}
}
