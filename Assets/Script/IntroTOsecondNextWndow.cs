using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroTOsecondNextWndow : MonoBehaviour {
	
	void Start () {
		SetOldLanguage(PlayerPrefs.GetString("language", "ENG"));
		Invoke ("NextLevel", 4);
	}

	void NextLevel() {
		SceneManager.LoadScene ("screen2", LoadSceneMode.Single);
	}
		
	private void SetOldLanguage(string lang) {
		if (lang == EnumLanguagesScript.Language.ENG.ToString ()) {
			EnumLanguagesScript.SetOldLanguage  (EnumLanguagesScript.Language.ENG);
		}
		if (lang == EnumLanguagesScript.Language.IT.ToString ()) {
			EnumLanguagesScript.SetOldLanguage  (EnumLanguagesScript.Language.IT);
		}
		if (lang == EnumLanguagesScript.Language.ESP.ToString ()) {
			EnumLanguagesScript.SetOldLanguage  (EnumLanguagesScript.Language.ESP);
		}
		if (lang == EnumLanguagesScript.Language.PT.ToString ()) {
			EnumLanguagesScript.SetOldLanguage  (EnumLanguagesScript.Language.PT);
		}
		if (lang == EnumLanguagesScript.Language.RU.ToString ()) {
			EnumLanguagesScript.SetOldLanguage  (EnumLanguagesScript.Language.RU);
		}
	}
	}