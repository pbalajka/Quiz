using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CallWaterPersonEnd : MonoBehaviour {

	public void CallWaterPerson(){
		SceneManager.LoadScene ("EndWaterPersonScene", LoadSceneMode.Single);
	}
		
}
