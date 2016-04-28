using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CallWaterPersonEnd : MonoBehaviour {

	public void CallWaterPerson(){
		Debug.Log ("volam postavicku vody na konci");
		SceneManager.LoadScene ("EndWaterPersonScene", LoadSceneMode.Single);
	}



}
