using UnityEngine;
using System.Collections;

public class LanguageAnswerScritp : MonoBehaviour {
	//Anglictina odpovede chybaju dve odpovede
	private static string[] answerENG = {"laska","placer", "felicita", "beleza", "nadejus", "esthetique", "krasny", "te amo", "amo il", "eu te amo", "bog", "stvoritel" };

	//Talianske odpovede
	private static string[] answerIT= {"love","placer", "stesti", "beleza", "nadejus", "esthetique", "krasny", "te amo", "lubim sa", "eu te amo", "bog", "stvoritel" };

	//Spanielske odpovede 
	private static string[] answerESP = {"love","placer", "felicita", "beleza", "nadejus", "esthetique", "nice", "milujem sa", "amo il", "te amo", "bog", "stvoritel" };

	//Portugalske odpovede
	private static string[] answerPT = {"love","placer", "felicita", "krasa", "nadejus", "esthetique", "nice", "te amo", "amo il", "lubim ta", "bog", "stvoritel" };

	//Ruske odpovede
	private static string[] answerRU = {"ласка","плaцeр", "фeлицитa", "бeлeзa", "нaдeй", "ecтeтик", "ницe", "тэ амo", "amo ил", "eу тe aмo", "бог", "cтвopитeл" };
	//Error
	private static string errorENG = "Error";

	public static string GetAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answerENG[answerNunber - 1]; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return answerIT[answerNunber - 1];
		case EnumLanguagesScript.Language.ESP:
			return answerESP[answerNunber - 1];
		case EnumLanguagesScript.Language.PT:
			return answerPT[answerNunber - 1];
		case EnumLanguagesScript.Language.RU:
			return answerRU[answerNunber - 1];
		default :
			return errorENG;
		}
	}
}