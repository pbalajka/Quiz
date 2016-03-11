using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BackScene(){
		SceneManager.LoadScene ("game1", LoadSceneMode.Single);
	}
}
