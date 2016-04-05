using UnityEngine;
using System.Collections;

public class LanguageScriptButton : MonoBehaviour {
	//ENG button
	private static string engENG="english";
	private static string engIT="italian";
	private static string engESP="spanish";
	private static string engPT="portuguese";
	private static string engRU="russian";
	//IT button
	private static string itENG="inglese";
	private static string itIT="italiano";
	private static string itESP="spagnolo";
	private static string itPT="portoghese";
	private static string itRU="russo";
	//ESP button
	private static string espENG="inglés";
	private static string espIT="italiano";
	private static string espESP="español";
	private static string espPT="portugués";
	private static string espRU="ruso";
	//PT
	private static string ptENG="inglés";
	private static string ptIT="italiano";
	private static string ptESP="español";
	private static string ptPT="portugués";
	private static string ptRU="ruso";
	//RU
	private static string ruENG="английский";
	private static string ruIT="итальянский";
	private static string ruESP="испанский";
	private static string ruPT="португальский";
	private static string ruRU="русский";
	//Error

	private static string errorENG = "Error";


	public static string GetEngButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engENG; 
		case EnumLanguagesScript.Language.IT:
			return itENG;
		case EnumLanguagesScript.Language.ESP:
			return espENG;
		case EnumLanguagesScript.Language.PT:
			return ptENG;
		case EnumLanguagesScript.Language.RU:
			return ruENG;
		default :
			return errorENG;
		}
	}

	public static string GetItButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engIT; 
		case EnumLanguagesScript.Language.IT:
			return itIT;
		case EnumLanguagesScript.Language.ESP:
			return espIT;
		case EnumLanguagesScript.Language.PT:
			return ptIT;
		case EnumLanguagesScript.Language.RU:
			return ruIT;
		default :
			return errorENG;
		}
	}

	public static string GetEspButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engESP; 
		case EnumLanguagesScript.Language.IT:
			return itESP;
		case EnumLanguagesScript.Language.ESP:
			return espESP;
		case EnumLanguagesScript.Language.PT:
			return ptESP;
		case EnumLanguagesScript.Language.RU:
			return ruESP;
		default :
			return errorENG;
		}
	}

	public static string GetPtButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engPT; 
		case EnumLanguagesScript.Language.IT:
			return itPT;
		case EnumLanguagesScript.Language.ESP:
			return espPT;
		case EnumLanguagesScript.Language.PT:
			return ptPT;
		case EnumLanguagesScript.Language.RU:
			return ruPT;
		default :
			return errorENG;
		}
	}

	public static string GetRuButton() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return engRU; 
		case EnumLanguagesScript.Language.IT:
			return itRU;
		case EnumLanguagesScript.Language.ESP:
			return espRU;
		case EnumLanguagesScript.Language.PT:
			return ptRU;
		case EnumLanguagesScript.Language.RU:
			return ruRU;
		default :
			return errorENG;
		}
	}
}