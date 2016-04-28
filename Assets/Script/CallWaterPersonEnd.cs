using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CallWaterPersonEnd : MonoBehaviour {

	public void CallWaterPerson(){
		Invoke ("OpenEndWaterPersonScene", 1);
	}

	private void OpenEndWaterPersonScene(){
		SceneManager.LoadScene ("EndWaterPersonScene", LoadSceneMode.Single);
		Debug.Log ("volam postavicku vody na konci");

	}



}
