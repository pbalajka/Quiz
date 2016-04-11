using UnityEngine;
using System.Collections;

public class LanguageForSmile : MonoBehaviour {
	private static string[] goodENG = {"", ""};
	private static string[] badENG = {"", ""};

	private static string[] goodIT = {"", ""};
	private static string[] badIT = {"", ""};

	private static string[] goodESP = {"", ""};
	private static string[] badESP = {"", ""};

	private static string[] goodPT = {"", ""};
	private static string[] badPT = {"", ""};

	private static string[] goodRU = {"", ""};
	private static string[] badRU = {"", ""};

	private static string errorENG = "Error";


	public static string GetGoodAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return goodENG[answerNunber - 1]; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return goodIT[answerNunber - 1];
		case EnumLanguagesScript.Language.ESP:
			return goodESP[answerNunber - 1];
		case EnumLanguagesScript.Language.PT:
			return goodPT[answerNunber - 1];
		case EnumLanguagesScript.Language.RU:
			return goodRU[answerNunber - 1];
		default :
			return errorENG;
		}
	}

	public static string GetBadAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return badENG[answerNunber - 1]; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return badIT[answerNunber - 1];
		case EnumLanguagesScript.Language.ESP:
			return badESP[answerNunber - 1];
		case EnumLanguagesScript.Language.PT:
			return badPT[answerNunber - 1];
		case EnumLanguagesScript.Language.RU:
			return badRU[answerNunber - 1];
		default :
			return errorENG;
		}
	}
}