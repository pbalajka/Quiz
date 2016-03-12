using UnityEngine;
using System.Collections;

public class MultiLanguageQuestScript : MonoBehaviour {
	//Anglicke otazky
	private static string quest1ENG ="How do you say love in Czech?";
	private static string quest2ENG ="How do you say joy in Spanish";
	private static string quest3ENG ="How do you say luck in Italian?";
	private static string quest4ENG ="How do you say beauty in Portuguese?";
	private static string quest5ENG ="How do you say hope in Russian?";
	private static string quest6ENG ="How do you say aesthetics in French?";
	private static string quest7ENG ="How do you say beautiful in Slovak?";
	private static string quest8ENG ="How do you say I love myself in Spanish?";
	private static string quest9ENG ="How do you say I love myself in Italian?";
	private static string quest10ENG ="How do you say I love you in Portuguese?";
	private static string quest11ENG ="How do you say God in Russian?";
	private static string quest12ENG ="How do you say creator in Slovak?";
	//Talianske otazky
	private static string quest1IT ="Come si dice amore di inglese ?";
	private static string quest2IT ="Come si dice di spagnolo piacere ?";
	private static string quest3IT ="Come si dice felicità di ceco ?";
	private static string quest4IT ="Come si dice bellezza di portoghese ?";
	private static string quest5IT ="Come si dice spero di russo ?";
	private static string quest6IT ="Come si dice estetica di francese ?";
	private static string quest7IT ="Come si dice bella di inglese ?";
	private static string quest8IT ="Come si dice ti amo di spagnolo ?";
	private static string quest9IT ="Come dite che io amo di lingua slovacca ?";
	private static string quest10IT ="Come si dice ti amo di portoghese ?";
	private static string quest11IT ="Come faccio a dire che Dio di russo ?";
	private static string quest12IT ="Come si dice Creatore di slovacco?";
	//Spanielske otazky
	private static string quest1ESP ="";
	private static string quest2ESP ="";
	private static string quest3ESP ="";
	private static string quest4ESP ="";
	private static string quest5ESP ="";
	private static string quest6ESP ="";
	private static string quest7ESP ="";
	private static string quest8ESP ="";
	private static string quest9ESP ="";
	private static string quest10ESP ="";
	private static string quest11ESP ="";
	private static string quest12ESP ="";
	//Portugalske otazky
	private static string quest1PT ="";
	private static string quest2PT ="";
	private static string quest3PT ="";
	private static string quest4PT ="";
	private static string quest5PT ="";
	private static string quest6PT ="";
	private static string quest7PT ="";
	private static string quest8PT ="";
	private static string quest9PT ="";
	private static string quest10PT ="";
	private static string quest11PT ="";
	private static string quest12PT ="";
	//Ruske otazky
	private static string quest1RU ="";
	private static string quest2RU ="";
	private static string quest3RU ="";
	private static string quest4RU ="";
	private static string quest5RU ="";
	private static string quest6RU ="";
	private static string quest7RU ="";
	private static string quest8RU ="";
	private static string quest9RU ="";
	private static string quest10RU ="";
	private static string quest11RU ="";
	private static string quest12RU ="";

	//Error
	private static string errorENG = "Error, do not load message";

	public static string Get1Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest1ENG;
		case EnumLanguagesScript.Language.IT:
			return quest1IT;
		case EnumLanguagesScript.Language.ESP:
			return quest1ESP;
		case EnumLanguagesScript.Language.PT:
			return quest1PT;
		case EnumLanguagesScript.Language.RU:
			return quest1RU;
		default :
			return errorENG;
		}
	}

	public static string Get2Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest2ENG;
		case EnumLanguagesScript.Language.IT:
			return quest2IT;
		case EnumLanguagesScript.Language.ESP:
			return quest2ESP;
		case EnumLanguagesScript.Language.PT:
			return quest2PT;
		case EnumLanguagesScript.Language.RU:
			return quest2RU;
		default :
			return errorENG;
		}
	}

	public static string Get3Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest3ENG;
		case EnumLanguagesScript.Language.IT:
			return quest3IT;
		case EnumLanguagesScript.Language.ESP:
			return quest3ESP;
		case EnumLanguagesScript.Language.PT:
			return quest3PT;
		case EnumLanguagesScript.Language.RU:
			return quest3RU;
		default :
			return errorENG;
		}
	}

	public static string Get4Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest4ENG;
		case EnumLanguagesScript.Language.IT:
			return quest4IT;
		case EnumLanguagesScript.Language.ESP:
			return quest4ESP;
		case EnumLanguagesScript.Language.PT:
			return quest4PT;
		case EnumLanguagesScript.Language.RU:
			return quest4RU;
		default :
			return errorENG;
		}
	}

	public static string Get5Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest5ENG;
		case EnumLanguagesScript.Language.IT:
			return quest5IT;
		case EnumLanguagesScript.Language.ESP:
			return quest5ESP;
		case EnumLanguagesScript.Language.PT:
			return quest5PT;
		case EnumLanguagesScript.Language.RU:
			return quest5RU;
		default :
			return errorENG;
		}
	}
		public static string Get6Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest6ENG;
		case EnumLanguagesScript.Language.IT:
			return quest6IT;
		case EnumLanguagesScript.Language.ESP:
			return quest6ESP;
		case EnumLanguagesScript.Language.PT:
			return quest6PT;
		case EnumLanguagesScript.Language.RU:
			return quest6RU;
		default :
			return errorENG;
		}
	}

	public static string Get7Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest7ENG;
		case EnumLanguagesScript.Language.IT:
			return quest7IT;
		case EnumLanguagesScript.Language.ESP:
			return quest7ESP;
		case EnumLanguagesScript.Language.PT:
			return quest7PT;
		case EnumLanguagesScript.Language.RU:
			return quest7RU;
		default :
			return errorENG;
		}
	}

	public static string Get8Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest8ENG;
		case EnumLanguagesScript.Language.IT:
			return quest8IT;
		case EnumLanguagesScript.Language.ESP:
			return quest8ESP;
		case EnumLanguagesScript.Language.PT:
			return quest8PT;
		case EnumLanguagesScript.Language.RU:
			return quest8RU;
		default :
			return errorENG;
		}
	}
		public static string Get9Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest9ENG;
		case EnumLanguagesScript.Language.IT:
			return quest9IT;
		case EnumLanguagesScript.Language.ESP:
			return quest9ESP;
		case EnumLanguagesScript.Language.PT:
			return quest9PT;
		case EnumLanguagesScript.Language.RU:
			return quest9RU;
		default :
			return errorENG;
		}
	}
		public static string Get10Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest10ENG;
		case EnumLanguagesScript.Language.IT:
			return quest10IT;
		case EnumLanguagesScript.Language.ESP:
			return quest10ESP;
		case EnumLanguagesScript.Language.PT:
			return quest10PT;
		case EnumLanguagesScript.Language.RU:
			return quest10RU;
		default :
			return errorENG;
		}
	}

	public static string Get11Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest11ENG;
		case EnumLanguagesScript.Language.IT:
			return quest11IT;
		case EnumLanguagesScript.Language.ESP:
			return quest11ESP;
		case EnumLanguagesScript.Language.PT:
			return quest11PT;
		case EnumLanguagesScript.Language.RU:
			return quest11RU;
		default :
			return errorENG;
		}
	}
		public static string Get12Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest12ENG;
		case EnumLanguagesScript.Language.IT:
			return quest12IT;
		case EnumLanguagesScript.Language.ESP:
			return quest12ESP;
		case EnumLanguagesScript.Language.PT:
			return quest12PT;
		case EnumLanguagesScript.Language.RU:
			return quest12RU;
		default :
			return errorENG;
		}
	}
}