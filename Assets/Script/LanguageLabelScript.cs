using UnityEngine;
using System.Collections;

public class LanguageLabelScript : MonoBehaviour {
	//Anglicke texty k tlacidlam a popisom
	private static string saveENG = "SAVE";
	private static string endENG = "END";
	private static string orENG = "or";
	private static string continueENG = "CONTINUE";
	private static string newGameENG = "START NEW";
	private static string languageENG = "language";
	private static string questionENG = "Question";
	//Talianske texty k tlacidlam a popisom
	private static string saveIT="SALVA";
	private static string endIT="ALLA FINE";
	private static string orIT="o";
	private static string continueIT="CONTINUANO";
	private static string newGameIT="AVVIARE NUOVE";
	private static string languageIT = "lingua";
	private static string questionIT = "Domanda";
	//Portugalske texty k tlacidlam a popisom
	private static string savePT="SALVAR";
	private static string endPT="FINALIZAR";
	private static string orPT="ou";
	private static string continuePT="CONTINUAR";
	private static string newGamePT="INICIAR NOVO";
	private static string languagePT = "língua";
	private static string questionPT = "Pergunta";
	//Spanielske texty k tlacidlam a popipublic string SaveENG {
	private static string saveESP="GUARDAR";
	private static string endESP="TERMINAR";
	private static string orESP="o";
	private static string continueESP="CONTINÚE";
	private static string newGameESP="INICIAR NUEVA";
	private static string languageESP = "lenguaje";
	private static string questionESP = "Pregunta";
	//Rustina texty k tlacidlam a popisom
	private static string saveRU="СОХРАНИТЬ";
	private static string endRU="КОНЕЦ";
	private static string orRU="или";
	private static string continueRU="ПРОДОЛЖАТЬ";
	private static string newGameRU="НАЧАЛА НОВОГО";
	private static string languageRU = "Язык";
	private static string questionRU = "Вопрос";
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