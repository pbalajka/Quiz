using UnityEngine;
using System.Collections;

public class SaveScript : MonoBehaviour {

	public void SaveGame() {
		PlayerPrefs.SetInt ("question", ActualSceneNunberScript.SceneNumber());
		print ("Save");
	}
}