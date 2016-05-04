using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetBubleText : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();

		text.text = LanguageForDrinkWater.GetDrinkAnswer (0)+LanguageForDrinkWater.GetDrinkAnswer (1)+ LanguageForDrinkWater.GetDrinkAnswer (2)+LanguageForDrinkWater.GetDrinkAnswer (3);

}
}