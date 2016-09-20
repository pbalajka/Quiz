using UnityEngine;
using System.Collections;

public class LanguageEnd6Label : MonoBehaviour {


	//Anglicke texty k tlacidlam a popisom
	private static string downloadENG = "Download";
	private static string endENG = "END";
	private static string orENG = "or";
	private static string thxENG="Thank You \nmuch";

	//Talianske texty k tlacidlam a popisom
	private static string downloadIT="SCARICARE";
	private static string endIT="FINE";
	private static string orIT="o";
	private static string thxIT="Grazie \nmille";

	//Portugalske texty k tlacidlam a popisom
	private static string downloadPT="BAIXAR";
	private static string endPT="FINALIZ";
	private static string orPT="ou";
	private static string thxPT="Muito \nobrigado";

	//Spanielske texty k tlacidlam a popipublic string SaveENG {
	private static string downloadESP="DESCARGAR";
	private static string endESP="SALIDA";
	private static string orESP="o";
	private static string thxESP="mucho \nGracias";

	//Rustina texty k tlacidlam a popisom
	private static string downloadRU="ЗАГРУЗИТЬ";
	private static string endRU="КОНЕЦ";
	private static string orRU="или";
	private static string thxRU="БОЛЬШОЕ \nСПАСИБО";

	//Error ENG string
	private static string errorENG = "Error";



	public static string GetDownload(){
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return downloadENG;
		case EnumLanguagesScript.Language.IT:
			return downloadIT;
		case EnumLanguagesScript.Language.ESP:
			return downloadESP;
		case EnumLanguagesScript.Language.PT:
			return downloadPT;
		case EnumLanguagesScript.Language.RU:
			return downloadRU;
		default :
			return errorENG;
		}
	
	}

	public static string GetEnd(){
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
	public static string GetThx() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return thxENG;
		case EnumLanguagesScript.Language.IT:
			return thxIT;
		case EnumLanguagesScript.Language.ESP:
			return thxESP;
		case EnumLanguagesScript.Language.PT:
			return thxPT;
		case EnumLanguagesScript.Language.RU:
			return thxRU;
		default :
			return errorENG;
		}
	}
}
