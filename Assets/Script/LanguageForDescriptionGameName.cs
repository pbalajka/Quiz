using UnityEngine;
using System.Collections;

public class LanguageForDescriptionGameName : MonoBehaviour {

	private static string gameNameENG = "The game-quiz  description";
	private static string gameNameIT = "Descrizione del gioco";
	private static string gameNameESP = "Descripción del juego";
	private static string gameNamePT = "Jogo Descrição";
	private static string gameNameRU = "Описание игры";

	private static string errorENG = "Error";

	public static string GetGameName() {
		switch (EnumLanguagesScript.GetLanguage()) {
		case EnumLanguagesScript.Language.ENG:
			return gameNameENG; 
		case EnumLanguagesScript.Language.IT:
			return gameNameIT;
		case EnumLanguagesScript.Language.ESP:
			return gameNameESP;
		case EnumLanguagesScript.Language.PT:
			return gameNamePT;
		case EnumLanguagesScript.Language.RU:
			return gameNameRU;
		default :
			return errorENG;
		}
	}
}
