using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectLanguage : MonoBehaviour {

	public void SetENG(){
		EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.ENG);
		NextLevel ();
	}

	public void SetESP(){
		EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.ESP);
		NextLevel ();
	}

	public void SetIT(){
		EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.IT);
		NextLevel ();
	}

	public void SetPT(){
		EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.PT);
		NextLevel ();
	}
	public void SetRU(){
		EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.RU);
		NextLevel ();
	}


	void NextLevel() {
		SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
	}
}
