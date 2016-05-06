using UnityEngine;
using System.Collections;

public class SaveScript : MonoBehaviour {

	public void SaveGame() {
		PlayerPrefs.SetInt ("question", ActualSceneNunberScript.SceneNumber());
		PlayerPrefs.SetInt ("wrongIndex", ImageAnswerScript.GetWrongIndex());
		PlayerPrefs.SetInt ("goodIndex", ImageAnswerScript.GetGoodIndex());
		//PlayerPrefs.SetString ("language", EnumLanguagesScript.GetLanguage ().ToString());
		PlayerPrefs.SetString ("answer", SetCorrectLetter.GetActualAnswer());
		PlayerPrefs.SetString ("pretocene", ImageAnswerScript.GetPretocene().ToString());
		PlayerPrefs.SetString ("teraz", ImageAnswerScript.GetTeraz().ToString());
		PlayerPrefs.SetString ("first", ImageAnswerScript.GetFirst().ToString());
	}
}