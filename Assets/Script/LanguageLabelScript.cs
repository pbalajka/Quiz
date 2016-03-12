﻿using UnityEngine;
using System.Collections;

public class LanguageLabelScript : MonoBehaviour {
	//Anglicke texty k tlacidlam a popisom
	private static string saveENG = "Save";
	private static string endENG = "End";
	private static string orENG = "or";
	private static string continueENG = "CONTINUE";
	private static string newGameENG = "START NEW";
	private static string languageENG = "Language";
	private static string questionENG = "Question";
	//Talianske texty k tlacidlam a popisom
	private static string saveIT;
	private static string endIT;
	private static string orIT;
	private static string continueIT;
	private static string newGameIT;
	private static string languageIT = "Language";
	private static string questionIT = "Question";
	//Portugalske texty k tlacidlam a popisom
	private static string savePT;
	private static string endPT;
	private static string orPT;
	private static string continuePT;
	private static string newGamePT;
	private static string languagePT = "Language";
	private static string questionPT = "Question";
	//Spanielske texty k tlacidlam a popipublic string SaveENG {
	private static string saveESP;
	private static string endESP;
	private static string orESP;
	private static string continueESP;
	private static string newGameESP;
	private static string languageESP = "Language";
	private static string questionESP = "Question";
	//Rustina texty k tlacidlam a popisom
	private static string saveRU;
	private static string endRU;
	private static string orRU;
	private static string continueRU;
	private static string newGameRU;
	private static string languageRU = "Language";
	private static string questionRU = "Question";
	//Error ENG string
	private static string errorENG = "Error";



	public static string GetSave() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return saveENG;
		case EnumLanguagesScript.Language.IT:
			return saveIT;
		case EnumLanguagesScript.Language.ESP:
			return saveESP;
		case EnumLanguagesScript.Language.PT:
			return savePT;
		case EnumLanguagesScript.Language.RU:
			return saveRU;
		default :
			return errorENG;
		}
	}

	public static string GetExit() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return endENG;
		case EnumLanguagesScript.Language.IT:
			return endIT;
		case EnumLanguagesScript.Language.ESP:
			return endESP;
		case EnumLanguagesScript.Language.PT:
			return endPT;
		case EnumLanguagesScript.Language.RU:
			return endRU;
		default :
			return errorENG;
		}
	}

	public static string GetOr() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return orENG;
		case EnumLanguagesScript.Language.IT:
			return orIT;
		case EnumLanguagesScript.Language.ESP:
			return orESP;
		case EnumLanguagesScript.Language.PT:
			return orPT;
		case EnumLanguagesScript.Language.RU:
			return orRU;
		default :
			return errorENG;
		}
	}

	public static string GetContinue() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return continueENG;
		case EnumLanguagesScript.Language.IT:
			return continueIT;
		case EnumLanguagesScript.Language.ESP:
			return continueESP;
		case EnumLanguagesScript.Language.PT:
			return continuePT;
		case EnumLanguagesScript.Language.RU:
			return continueRU;
		default :
			return errorENG;
		}
	}

	public static string GetNewGame() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return newGameENG;
		case EnumLanguagesScript.Language.IT:
			return newGameIT;
		case EnumLanguagesScript.Language.ESP:
			return newGameESP;
		case EnumLanguagesScript.Language.PT:
			return newGamePT;
		case EnumLanguagesScript.Language.RU:
			return newGameRU;
		default :
			return errorENG;
		}
	}

	public static string GetLanguage() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return languageENG;
		case EnumLanguagesScript.Language.IT:
			return languageIT;
		case EnumLanguagesScript.Language.ESP:
			return languageESP;
		case EnumLanguagesScript.Language.PT:
			return languagePT;
		case EnumLanguagesScript.Language.RU:
			return languageRU;
		default :
			return errorENG;
		}
	}

	public static string GetQuestion() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return questionENG;
		case EnumLanguagesScript.Language.IT:
			return questionIT;
		case EnumLanguagesScript.Language.ESP:
			return questionESP;
		case EnumLanguagesScript.Language.PT:
			return questionPT;
		case EnumLanguagesScript.Language.RU:
			return questionRU;
		default :
			return errorENG;
		}
	}
}