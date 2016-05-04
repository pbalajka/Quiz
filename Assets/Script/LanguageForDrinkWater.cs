using UnityEngine;
using System.Collections;

public class LanguageForDrinkWater : MonoBehaviour {
	private static string[] drinkENG = {"Do you have drinking water?\n", "Drink, ", "Cheers\n", "It is necessary."};
	private static string[] drinkIT = {"Avete acqua potabile?\n", "Bere, ", "Cin cin.\n", "Necessario"};
	private static string[] drinkESP = {"¿Tiene el agua potable?\n", "bebida, ", "¡Salud.\n", "Es necesario."};
	private static string[] drinkPT = {"Você tem água potável?\n", "Bebida, ", "Saúde.\n", "Necessário."};
	private static string[] drinkRU = {"У вас есть питьевая вода?\n", "Напиток нa здоровье. ,", "Приветствия.\n", "Надо вам пить воды."};

	private static string errorENG = "Error";

	public static string GetDrinkAnswer(int drinkText) {
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
