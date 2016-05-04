using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {
	private static string noLoaded = "nothing_to_do";

	void Start() {
		string lang = PlayerPrefs.GetString("language", "ENG");
		SetLanguage (lang);
	}

	public void LoadGame() {
		// Nacitanie aktualnej odpovede
		string answer = PlayerPrefs.GetString ("answer", noLoaded);
		if(answer != noLoaded)
			SetCorrectLetter.SetLoadedAnswer (answer);
		//Load scene
		int guest = PlayerPrefs.GetInt ("question", 0);
		string sceneLoad = "question_" + guest.ToString ();
		SceneManager.LoadScene (sceneLoad, LoadSceneMode.Single);
		//Load wrong answer
		int wrongIndex = PlayerPrefs.GetInt ("wrongIndex", 0);
		ImageAnswerScript.SetWrongIndex (wrongIndex);
		//Load good answer
		int goodIndex = PlayerPrefs.GetInt ("goodIndex", 0);
		ImageAnswerScript.SetGoodIndex (goodIndex);
	}

	private void SetLanguage(string lang) {
		if (lang == EnumLanguagesScript.Language.ENG.ToString ()) {
			EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.ENG);
		}
		if (lang == EnumLanguagesScript.Language.IT.ToString ()) {
			EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.IT);
		}
		if (lang == EnumLanguagesScript.Language.ESP.ToString ()) {
			EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.ESP);
		}
		if (lang == EnumLanguagesScript.Language.PT.ToString ()) {
			EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.PT);
		}
		if (lang == EnumLanguagesScript.Language.RU.ToString ()) {
			EnumLanguagesScript.SetLanguage (EnumLanguagesScript.Language.RU);
		}
	}
}