using UnityEngine;
using System.Collections;

public class LanguageForDrinkWater : MonoBehaviour {
	private static string[] drinkENG = {"Do you have drinking water?", "Drink", "Cheers", "It is necessary."};
	private static string[] drinkIT = {"Avete acqua potabile?", "Bere", "Cin cin.", "Necessario"};
	private static string[] drinkESP = {"¿Tiene el agua potable?", "bebida", "¡Salud.", "Es necesario."};
	private static string[] drinkPT = {"Você tem água potável?", "Bebida", "Saúde.", "Necessário."};
	private static string[] drinkRU = {"У вас есть питьевая вода?", "Напиток", "Приветствия.", "Это вам надо."};

	private static string errorENG = "Error";

	public static string GetGoodAnswer(int drinkText) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return drinkENG [drinkText]; 
		case EnumLanguagesScript.Language.IT:
			return drinkIT [drinkText];
		case EnumLanguagesScript.Language.ESP:
			return drinkESP [drinkText];
		case EnumLanguagesScript.Language.PT:
			return drinkPT [drinkText];
		case EnumLanguagesScript.Language.RU:
			return drinkRU [drinkText];
		default :
			return errorENG;
		}
	}


	public static int GetCountDrinkText() {
		return drinkENG.Length;
	}
}
