using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetQuestionLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = LanguageLabelScript.GetQuestion() + " " + ActualSceneNunberScript.SceneNumber().ToString();
	}
}