using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NexWindow2 : MonoBehaviour {
	private bool isAndroid;
	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.Android) {
			isAndroid = true;
		} else {
			isAndroid = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isAndroid) {
			if (Input.touches.Length > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
				SceneManager.LoadScene ("game1", LoadSceneMode.Single);
			}
		} else {
			if(Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("game1", LoadSceneMode.Single);
			}
		}
	
	}
}
