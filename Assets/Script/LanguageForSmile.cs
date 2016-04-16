using UnityEngine;
using System.Collections;

public class LanguageForSmile : MonoBehaviour {
	private static string[] goodENG = {"I’m happy for your skill.", "I feel joy because of your success.", "I’m happy seeing you doing well.", "Knowing that you’re doing really well makes me happy.","Skills which you’re learning will come in handy in your life.","Patience is the crown of success."};
	private static string[] badENG = {"Try to guess the letters.", "Keep on going, you’ll make it.", "Patience is what you’re learning.", "Mistakes and errors are just a way of learning.","You will make it, believe in yourself.","Creativity is open to you.","You are able to make it.","Your skill will help you."};

	private static string[] goodIT = {"Gioisco della tua bravura.", "Gioisco del tuo successo.", "Gioisco come ci stai riuscendo.", "Gioisco come ci riesci fare.","La bravura che stai imparando ti servirá nella vita.","La pazienza é la corona del successo."};
	private static string[] badIT = {"Prova a indovinare le lettere.", "Continua ancora se ci riesci. ", "Pazienza é quello che stai imparando.", "Errore e sbaglio é solo un modo di insegnamento.","C´e la fai, fidati di te.","La tua creativitá si apre.","Sei in grado di farcela","La tua bravura ti aiuterá."};

	private static string[] goodESP = {"Me alegro de tu destreza.", "Me alegro de tu éxito.", "Me alegro de que te vaya bien.", "Me alegro de que lo hagas bien.","La destreza que vas adquiriendo será muy útil en tu vida.","La paciencia es la corona del éxito."};
	private static string[] badESP = {"Intenta  adivinar las letras.", "Continúa,  eres capaz de hacerlo con éxito.", "La paciencia es lo que estás aprendiendo.", "El fallo y el error son sólo una forma de aprendizaje.","Eres capaz de hacerlo con éxito, confía en tí mismo.","Se te abre la creatividad.","Eres capaz de  superarlo.","Te ayuda tu destreza."};

	private static string[] goodPT = {"", "", "", "","",""};
	private static string[] badPT = {"", "", "", "","","","",""};

	private static string[] goodRU = {"Я радуюсь Твоему мастерству.", "Я радуюсь Твоему успеху.", "Я радуюсь как Тебе все дается.", "Я радуюсь как Ты со всем справляешься.","Мастерство, которому Ты учишься, Тебе в жизни годится.","Терпение завершено успехом."};
	private static string[] badRU = {"Попробуй угадать буквы.", "Продолжай по-прежнему, ты можешь справиться с этим.", "Терпение - это то, чему ты учишься.", "Ошибки и погрешности - это только способ учения.","Ты можешь справиться с этим, доверяй себе.","Открывается Твое творчество.","Ты способен/cпособна с этим справиться.","Твое мастерство поможет Тебе."};

	private static string errorENG = "Error";


	public static string GetGoodAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return goodENG[answerNunber]; 
		case EnumLanguagesScript.Language.IT:
			return goodIT[answerNunber];
		case EnumLanguagesScript.Language.ESP:
			return goodESP[answerNunber];
		case EnumLanguagesScript.Language.PT:
			return goodPT[answerNunber];
		case EnumLanguagesScript.Language.RU:
			return goodRU[answerNunber];
		default :
			return errorENG;
		}
	}

	public static string GetBadAnswer(int answerNunber) {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return badENG[answerNunber]; // -1 kvoli tomu ze pole je cislovane od 0 a odpovede od 1
		case EnumLanguagesScript.Language.IT:
			return badIT[answerNunber];
		case EnumLanguagesScript.Language.ESP:
			return badESP[answerNunber];
		case EnumLanguagesScript.Language.PT:
			return badPT[answerNunber];
		case EnumLanguagesScript.Language.RU:
			return badRU[answerNunber];
		default :
			return errorENG;
		}
	}

	public static int GetCountGoodAnswer() {
		return goodENG.Length;
	}

	public static int GetCountBadAnswer() {
		return badENG.Length;
	}
}