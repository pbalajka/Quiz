using UnityEngine;
using System.Collections;

public class EnumLanguagesScript : MonoBehaviour {
	public enum Language{ENG, IT, ESP, PT, RU};
	private static Language lang = Language.ENG;

	public static Language GetLanguage() {
		return lang;
	}

	public static void SetLanguage(Language language){
		lang = language;
		PlayerPrefs.SetString ("language", GetLanguage ().ToString());
	}
}