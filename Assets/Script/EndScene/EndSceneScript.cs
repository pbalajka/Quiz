using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndSceneScript : MonoBehaviour {
	public Sprite first;
	public Sprite second;
	public Sprite third;
	public Sprite fourth;
	public Sprite fifth;	
	public Sprite sixth;
	public Sprite seventh; 
	public Sprite eighth;

	bool download = false;
	bool end = false;

	public GameObject gameObjectDownload;
	public GameObject gameObjectOr;
	public GameObject gameObjectEnd;

	// Use this for initialization
	void Start () {
		GetComponent<Image> ().sprite = first;
		Invoke ("CallImageSecond",4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CallImageSecond(){
		GetComponent<Image> ().sprite = second;
		Invoke ("CallImageThird",1);
	}
	void CallImageThird(){
		GetComponent<Image> ().sprite = third;
		Invoke ("CallImageFourth",1);
	}

	void CallImageFourth(){
		GetComponent<Image> ().sprite = fourth;
		Invoke ("CallImageFifth",1);
	}

	void CallImageFifth(){
		GetComponent<Image> ().sprite = fifth;
		Invoke ("CallImageSixth",1.5f);
	}

	void CallImageSixth(){
		GetComponent<Image> ().sprite = sixth;
		gameObjectDownload.SetActive (true);
		gameObjectOr.SetActive (true);
		gameObjectEnd.SetActive (true);
	}

	public void ClickButtDown(){
		GetComponent<Image> ().sprite = seventh;
		gameObjectDownload.SetActive (false);
		gameObjectOr.SetActive (false);
		gameObjectEnd.SetActive (false);
		Invoke ("CallImageEight", 2);
		download = true;
	}

	public void ClickButtEnd(){
		GetComponent<Image> ().sprite = seventh;
		gameObjectDownload.SetActive (false);
		gameObjectOr.SetActive (false);
		gameObjectEnd.SetActive (false);
		Invoke ("CallImageEight", 2);
		end = true;

	}

	void CallImageEight(){
		GetComponent<Image> ().sprite = eighth;
		if (end)
			Invoke ("EndGame", 2);
		if(download)
			print ("stahujeme");
		
	}

	void EndGame(){
		Application.Quit ();
		print ("koniec");
	}
}
