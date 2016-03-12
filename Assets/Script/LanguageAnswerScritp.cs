using UnityEngine;
using System.Collections;

public class LanguageAnswerScritp : MonoBehaviour {
	//Anglictina odpovede
	private static string answer1ENG = "";
	private static string answer2ENG;
	private static string answer3ENG;
	private static string answer4ENG;
	private static string answer5ENG;
	private static string answer6ENG;
	private static string answer7ENG;
	private static string answer8ENG;
	private static string answer9ENG;
	private static string answer10ENG;
	private static string answer11ENG;
	private static string answer12ENG;
	//Talianske odpovede
	private static string answer1IT;
	private static string answer2IT;
	private static string answer3IT;
	private static string answer4IT;
	private static string answer5IT;
	private static string answer6IT;
	private static string answer7IT;
	private static string answer8IT;
	private static string answer9IT;
	private static string answer10IT;
	private static string answer11IT;
	private static string answer12IT;
	//Spanielske odpovede
	private static string answer1ESP;
	private static string answer2ESP;
	private static string answer3ESP;
	private static string answer4ESP;
	private static string answer5ESP;
	private static string answer6ESP;
	private static string answer7ESP;
	private static string answer8ESP;
	private static string answer9ESP;
	private static string answer10ESP;
	private static string answer11ESP;
	private static string answer12ESP;
	//Portugalske odpovede
	private static string answer1PT;
	private static string answer2PT;
	private static string answer3PT;
	private static string answer4PT;
	private static string answer5PT;
	private static string answer6PT;
	private static string answer7PT;
	private static string answer8PT;
	private static string answer9PT;
	private static string answer10PT;
	private static string answer11PT;
	private static string answer12PT;
	//Ruske odpovede
	private static string answer1RU;
	private static string answer2RU;
	private static string answer3RU;
	private static string answer4RU;
	private static string answer5RU;
	private static string answer6RU;
	private static string answer7RU;
	private static string answer8RU;
	private static string answer9RU;
	private static string answer10RU;
	private static string answer11RU;
	private static string answer12RU;

	//Error
	private static string errorENG = "Error";

	public static string Get1Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer1ENG;
		case EnumLanguagesScript.Language.IT:
			return answer1IT;
		case EnumLanguagesScript.Language.ESP:
			return answer1ESP;
		case EnumLanguagesScript.Language.PT:
			return answer1PT;
		case EnumLanguagesScript.Language.RU:
			return answer1RU;
		default :
			return errorENG;
		}
	}

	public static string Get2Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer2ENG;
		case EnumLanguagesScript.Language.IT:
			return answer2IT;
		case EnumLanguagesScript.Language.ESP:
			return answer2ESP;
		case EnumLanguagesScript.Language.PT:
			return answer2PT;
		case EnumLanguagesScript.Language.RU:
			return answer2RU;
		default :
			return errorENG;
		}
	}

	public static string Get3Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer3ENG;
		case EnumLanguagesScript.Language.IT:
			return answer3IT;
		case EnumLanguagesScript.Language.ESP:
			return answer3ESP;
		case EnumLanguagesScript.Language.PT:
			return answer3PT;
		case EnumLanguagesScript.Language.RU:
			return answer3RU;
		default :
			return errorENG;
		}
	}

	public static string Get4Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer4ENG;
		case EnumLanguagesScript.Language.IT:
			return answer4IT;
		case EnumLanguagesScript.Language.ESP:
			return answer4ESP;
		case EnumLanguagesScript.Language.PT:
			return answer4PT;
		case EnumLanguagesScript.Language.RU:
			return answer4RU;
		default :
			return errorENG;
		}
	}

	public static string Get5Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer5ENG;
		case EnumLanguagesScript.Language.IT:
			return answer5IT;
		case EnumLanguagesScript.Language.ESP:
			return answer5ESP;
		case EnumLanguagesScript.Language.PT:
			return answer5PT;
		case EnumLanguagesScript.Language.RU:
			return answer5RU;
		default :
			return errorENG;
		}
	}

	public static string Get6Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer6ENG;
		case EnumLanguagesScript.Language.IT:
			return answer6IT;
		case EnumLanguagesScript.Language.ESP:
			return answer6ESP;
		case EnumLanguagesScript.Language.PT:
			return answer6PT;
		case EnumLanguagesScript.Language.RU:
			return answer6RU;
		default :
			return errorENG;
		}
	}

	public static string Get7Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer7ENG;
		case EnumLanguagesScript.Language.IT:
			return answer7IT;
		case EnumLanguagesScript.Language.ESP:
			return answer7ESP;
		case EnumLanguagesScript.Language.PT:
			return answer7PT;
		case EnumLanguagesScript.Language.RU:
			return answer7RU;
		default :
			return errorENG;
		}
	}

	public static string Get8Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer8ENG;
		case EnumLanguagesScript.Language.IT:
			return answer8IT;
		case EnumLanguagesScript.Language.ESP:
			return answer8ESP;
		case EnumLanguagesScript.Language.PT:
			return answer8PT;
		case EnumLanguagesScript.Language.RU:
			return answer8RU;
		default :
			return errorENG;
		}
	}

	public static string Get9Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer9ENG;
		case EnumLanguagesScript.Language.IT:
			return answer9IT;
		case EnumLanguagesScript.Language.ESP:
			return answer9ESP;
		case EnumLanguagesScript.Language.PT:
			return answer9PT;
		case EnumLanguagesScript.Language.RU:
			return answer9RU;
		default :
			return errorENG;
		}
	}

	public static string Get10Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer10ENG;
		case EnumLanguagesScript.Language.IT:
			return answer10IT;
		case EnumLanguagesScript.Language.ESP:
			return answer10ESP;
		case EnumLanguagesScript.Language.PT:
			return answer10PT;
		case EnumLanguagesScript.Language.RU:
			return answer10RU;
		default :
			return errorENG;
		}
	}

	public static string Get11Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer11ENG;
		case EnumLanguagesScript.Language.IT:
			return answer11IT;
		case EnumLanguagesScript.Language.ESP:
			return answer11ESP;
		case EnumLanguagesScript.Language.PT:
			return answer11PT;
		case EnumLanguagesScript.Language.RU:
			return answer11RU;
		default :
			return errorENG;
		}
	}

	public static string Get12Answer() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return answer12ENG;
		case EnumLanguagesScript.Language.IT:
			return answer12IT;
		case EnumLanguagesScript.Language.ESP:
			return answer12ESP;
		case EnumLanguagesScript.Language.PT:
			return answer12PT;
		case EnumLanguagesScript.Language.RU:
			return answer12RU;
		default :
			return errorENG;
		}
	}
}