using UnityEngine;
using System.Collections;

public class MultiLanguageQuestScript : MonoBehaviour {
	

	//Anglicke otazky
	private static string quest1ENG = "How do you say love in Czech?";
	private static string quest2ENG = "How do you say joy in Spanish";
	private static string quest3ENG;
	private static string quest4ENG;
	private static string quest5ENG;
	private static string quest6ENG;
	private static string quest7ENG;
	private static string quest8ENG;
	private static string quest9ENG;
	private static string quest10ENG;
	private static string quest11ENG;
	private static string quest12ENG;
	//Talianske otazky

	//Spanielske otazky

	//Portugalske otazky

	//Ruske otazky

	public static string Get1Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest1ENG;
		}
	}

}
