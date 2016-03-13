using UnityEngine;
using System.Collections;

public class LanguageAnswerScritp : MonoBehaviour {
	//Anglictina odpovede chybaju dve odpovede
	private static string[] answerENG = {"laska","placer", "felicità", "beleza", "надеюсь", "esthétique", "pekny", "amo il", "te amo", "bog" };
	private static string answer11ENG = "";
	private static string answer12ENG = "";
	//Talianske odpovede
	private static string[] answerIT;

	//Spanielske odpovede
	private static string[] answerESP;

	//Portugalske odpovede
	private static string[] answerPT;

	//Ruske odpovede
	private static string[] answerRU;
	//Error
	private static string errorENG = "Error";

	public static string GetAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answerENG[answerNunber - 1]; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return answerIT[answerNunber - 1];;
		case EnumLanguagesScript.Language.ESP:
			return answerESP[answerNunber - 1];;
		case EnumLanguagesScript.Language.PT:
			return answerPT[answerNunber - 1];;
		case EnumLanguagesScript.Language.RU:
			return answerRU[answerNunber - 1];;
		default :
			return errorENG;
		}
	}
}