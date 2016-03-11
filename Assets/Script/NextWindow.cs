using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script na prvej scene, prepnutie na druhu scenu
public class NextWindow : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Utils.IsMobil()) {
			if (Input.touches.Length > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
				SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
			}
		} else {
			if(Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
			}
		}
	}
}