using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetBubleText : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();

		if(SceneManager.GetActiveScene().name == "Description")
			text.text = LanguageForDrinkWater.GetDrinkAnswer (0);
		if(SceneManager.GetActiveScene().name == "EndWaterPersonScene")
			text.text = LanguageForDrinkWater.GetDrinkAnswer (1);
		if(SceneManager.GetActiveScene().name == "WaterPersonScene")
			text.text = LanguageForDrinkWater.GetDrinkAnswer (2);
		if(SceneManager.GetActiveScene().name == "End1")
			text.text = LanguageForDrinkWater.GetDrinkAnswer (3);
		if (LoadNewScene.GetNextSceneNUmber () == 4) {
			text.text = LanguageForDrinkWater.GetDrinkAnswer (0);
		}
		if (LoadNewScene.GetNextSceneNUmber () == 7) {
			text.text = LanguageForDrinkWater.GetDrinkAnswer (1);
		}
		if (LoadNewScene.GetNextSceneNUmber () == 10) {
			text.text = LanguageForDrinkWater.GetDrinkAnswer (2);
		}
	}

}
