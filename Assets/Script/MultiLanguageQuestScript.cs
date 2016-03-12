/*using UnityEngine;
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
	private static string quest1IT;
	private static string quest2ENG;
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
	//Spanielske otazky
	private static string quest1ENG;
	private static string quest2ENG;
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
	//Portugalske otazky
	private static string quest1PT;
	private static string quest2PT;
	private static string quest3PT;
	private static string quest4PT;
	private static string quest5PT;
	private static string quest6PT;
	private static string quest7PT;
	private static string quest8PT;
	private static string quest9PT;
	private static string quest10PT;
	private static string quest11PT;
	private static string quest12PT;
	//Ruske otazky
	private static string quest1RU;
	private static string quest2RU;
	private static string quest3RU;
	private static string quest4RU;
	private static string quest5RU;
	private static string quest6RU;
	private static string quest7RU;
	private static string quest8RU;
	private static string quest9RU;
	private static string quest10RU;
	private static string quest11RU;
	private static string quest12RU;

	public static string Get1Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest1ENG;
		case EnumLanguagesScript.Language.IT:
			return quest1IT;
		case EnumLanguagesScript.Language.ESP:
			return quest1ESp;
		case EnumLanguagesScript.Language.PT:
			return quest1PT;
		case EnumLanguagesScript.Language.RU:
			return quest1RU;
		}
	}

	public static string Get2Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest2ENG;
		case EnumLanguagesScript.Language.IT:
			return quest2IT;
		case EnumLanguagesScript.Language.ESP:
			return quest2ESp;
		case EnumLanguagesScript.Language.PT:
			return quest2PT;
		case EnumLanguagesScript.Language.RU:
			return quest2RU;
		}
	}

	public static string Get3Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest3ENG;
		case EnumLanguagesScript.Language.IT:
			return quest3IT;
		case EnumLanguagesScript.Language.ESP:
			return quest3ESp;
		case EnumLanguagesScript.Language.PT:
			return quest3PT;
		case EnumLanguagesScript.Language.RU:
			return quest3RU;
		}
	}

	public static string Get4Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest4ENG;
		case EnumLanguagesScript.Language.IT:
			return quest4IT;
		case EnumLanguagesScript.Language.ESP:
			return quest4ESp;
		case EnumLanguagesScript.Language.PT:
			return quest4PT;
		case EnumLanguagesScript.Language.RU:
			return quest4RU;
		}
	}

	public static string Get5Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest5ENG;
		case EnumLanguagesScript.Language.IT:
			return quest5IT;
		case EnumLanguagesScript.Language.ESP:
			return quest5ESp;
		case EnumLanguagesScript.Language.PT:
			return quest5PT;
		case EnumLanguagesScript.Language.RU:
			return quest5RU;
		}
	}
		public static string Get6Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest6ENG;
		case EnumLanguagesScript.Language.IT:
			return quest6IT;
		case EnumLanguagesScript.Language.ESP:
			return quest6ESp;
		case EnumLanguagesScript.Language.PT:
			return quest6PT;
		case EnumLanguagesScript.Language.RU:
			return quest6RU;
		}
	}

	public static string Get7Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest7ENG;
		case EnumLanguagesScript.Language.IT:
			return quest7IT;
		case EnumLanguagesScript.Language.ESP:
			return quest7ESp;
		case EnumLanguagesScript.Language.PT:
			return quest7PT;
		case EnumLanguagesScript.Language.RU:
			return quest7RU;
		}
	}

	public static string Get8Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest8ENG;
		case EnumLanguagesScript.Language.IT:
			return quest8IT;
		case EnumLanguagesScript.Language.ESP:
			return quest8ESp;
		case EnumLanguagesScript.Language.PT:
			return quest8PT;
		case EnumLanguagesScript.Language.RU:
			return quest8RU;
		}
	}
		public static string Get9Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest9ENG;
		case EnumLanguagesScript.Language.IT:
			return quest9IT;
		case EnumLanguagesScript.Language.ESP:
			return quest9ESp;
		case EnumLanguagesScript.Language.PT:
			return quest9PT;
		case EnumLanguagesScript.Language.RU:
			return quest9RU;
		}
	}
		public static string Get10Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest10ENG;
		case EnumLanguagesScript.Language.IT:
			return quest10IT;
		case EnumLanguagesScript.Language.ESP:
			return quest10ESp;
		case EnumLanguagesScript.Language.PT:
			return quest10PT;
		case EnumLanguagesScript.Language.RU:
			return quest10RU;
		}
	}

	public static string Get11Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest11ENG;
		case EnumLanguagesScript.Language.IT:
			return quest11IT;
		case EnumLanguagesScript.Language.ESP:
			return quest11ESp;
		case EnumLanguagesScript.Language.PT:
			return quest11PT;
		case EnumLanguagesScript.Language.RU:
			return quest11RU;
		}
	}
		public static string Get12Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest12ENG;
		case EnumLanguagesScript.Language.IT:
			return quest12IT;
		case EnumLanguagesScript.Language.ESP:
			return quest12ESp;
		case EnumLanguagesScript.Language.PT:
			return quest12PT;
		case EnumLanguagesScript.Language.RU:
			return quest12RU;
		}
	}
}
*/