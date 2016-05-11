using UnityEngine;
using System.Collections;

public class BackButtonExit : MonoBehaviour {
	int exitCount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyUp(KeyCode.Escape)){
			exitCount++;
			if(!IsInvoking("disableDoubleClick"))
				Invoke("disableDoubleClick", 0.6f);
		}
		if(exitCount == 2){
			CancelInvoke("disableDoubleClick");
			Application.Quit();
		}
		}

	void disableDoubleClick(){
		exitCount = 0;
	}

}

