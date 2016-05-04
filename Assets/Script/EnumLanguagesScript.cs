using UnityEngine;
using System.Collections;

public class EnumLanguagesScript : MonoBehaviour {
	public enum Language{ENG, IT, ESP, PT, RU};
	private static Language lang = Language.ENG;
	private static Language langOld;

	public static Language GetLanguage() {
		return lang;
	}

	public static void SetLanguage(Language language){
		lang = language;
		PlayerPrefs.SetString ("language", GetLanguage ().ToString());
		print (lang);
		print (langOld + " = old");
		if (lang != langOld) {
			ChangeContinueButton.SetChangedLanguage (true);
		} else {
			ChangeContinueButton.SetChangedLanguage (false);
		}
	}

	public static void SetOldLanguage(Language language) {
		langOld = language;
	}
}