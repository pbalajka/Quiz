using UnityEngine;
using System.Collections;

public class LanguageForDrinkWater : MonoBehaviour {
	private static string[] drinkENG = {"", ""};
	private static string[] drinkIT = {"", ""};
	private static string[] drinkESP = {"", ""};
	private static string[] drinkPT = {"", ""};
	private static string[] drinkRU = {"", ""};

	private static string errorENG = "Error";

	public static string GetGoodAnswer(int drinkText) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return drinkENG [drinkText]; 
		case EnumLanguagesScript.Language.IT:
			return drinkIT [drinkText];
		case EnumLanguagesScript.Language.ESP:
			return drinkESP [drinkText];
		case EnumLanguagesScript.Language.PT:
			return drinkPT [drinkText];
		case EnumLanguagesScript.Language.RU:
			return drinkRU [drinkText];
		default :
			return errorENG;
		}
	}


	public static int GetCountDrinkText() {
		return drinkENG.Length;
	}
}
