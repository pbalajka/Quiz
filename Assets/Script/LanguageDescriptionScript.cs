using UnityEngine;
using System.Collections;

public class LanguageDescriptionScript : MonoBehaviour {
	private static string descriptionENG;
	private static string descriptionIT;
	private static string descriptionESP;
	private static string descriptionPT;
	private static string descriptionRU;
	//Error
	private static string errorENG = "Error";

	public static string GetDescription() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return descriptionENG; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return descriptionIT;
		case EnumLanguagesScript.Language.ESP:
			return descriptionESP;
		case EnumLanguagesScript.Language.PT:
			return descriptionPT;
		case EnumLanguagesScript.Language.RU:
			return descriptionRU;
		default :
			return errorENG;
		}
	}
}