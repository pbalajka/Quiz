using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script na druhej scene prepnutie na prvu otazku
public class NexWindow2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Utils.IsMobil()) {
			if (Input.touches.Length > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
				SceneManager.LoadScene ("question_1", LoadSceneMode.Single);
			}
		} else {
			if(Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("question_1", LoadSceneMode.Single);
			}
		}
	}
}