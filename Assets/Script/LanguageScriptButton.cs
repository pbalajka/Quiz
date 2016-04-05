using UnityEngine;
using System.Collections;

public class LanguageScriptButton : MonoBehaviour {
	//ENG button
	private static string engENG;
	private static string engIT;
	private static string engESP;
	private static string engPT;
	private static string engRU;
	//IT button
	private static string itENG;
	private static string itIT;
	private static string itESP;
	private static string itPT;
	private static string itRU;
	//ESP button
	private static string espENG;
	private static string espIT;
	private static string espESP;
	private static string espPT;
	private static string espRU;
	//PT
	private static string ptENG;
	private static string ptIT;
	private static string ptESP;
	private static string ptPT;
	private static string ptRU;
	//RU
	private static string ruENG;
	private static string ruIT;
	private static string ruESP;
	private static string ruPT;
	private static string ruRU;
	//Error

	private static string errorENG = "Error";


	public static string GetEngButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engENG; 
		case EnumLanguagesScript.Language.IT:
			return engIT;
		case EnumLanguagesScript.Language.ESP:
			return engESP;
		case EnumLanguagesScript.Language.PT:
			return engPT;
		case EnumLanguagesScript.Language.RU:
			return engRU;
		default :
			return errorENG;
		}
	}

	public static string GetItButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return itENG; 
		case EnumLanguagesScript.Language.IT:
			return itIT;
		case EnumLanguagesScript.Language.ESP:
			return itESP;
		case EnumLanguagesScript.Language.PT:
			return itPT;
		case EnumLanguagesScript.Language.RU:
			return itRU;
		default :
			return errorENG;
		}
	}

	public static string GetEspButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return espENG; 
		case EnumLanguagesScript.Language.IT:
			return espIT;
		case EnumLanguagesScript.Language.ESP:
			return espESP;
		case EnumLanguagesScript.Language.PT:
			return espPT;
		case EnumLanguagesScript.Language.RU:
			return espRU;
		default :
			return errorENG;
		}
	}

	public static string GetPtButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return ptENG; 
		case EnumLanguagesScript.Language.IT:
			return ptIT;
		case EnumLanguagesScript.Language.ESP:
			return ptESP;
		case EnumLanguagesScript.Language.PT:
			return ptPT;
		case EnumLanguagesScript.Language.RU:
			return ptRU;
		default :
			return errorENG;
		}
	}

	public static string GetRuButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return ruENG; 
		case EnumLanguagesScript.Language.IT:
			return ruIT;
		case EnumLanguagesScript.Language.ESP:
			return ruESP;
		case EnumLanguagesScript.Language.PT:
			return ruPT;
		case EnumLanguagesScript.Language.RU:
			return ruRU;
		default :
			return errorENG;
		}
	}
}