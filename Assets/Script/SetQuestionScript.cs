using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetQuestionScript : MonoBehaviour {
	private string quest1 = "How do you say love in Czech?";
	private string quest2 = "How do you say joy in Spanish";
	private string quest3;
	private string quest4;
	private string quest5;
	private string quest6;
	private string quest7;
	private string quest8;
	private string quest9;
	private string quest10;
	private string quest11;
	private string quest12;

	// Use this for initialization
	void Start () {
		quest1 = MultiLanguageQuestScript.Get1Quest ();
		quest2 = MultiLanguageQuestScript.Get2Quest ();
		quest3 = MultiLanguageQuestScript.Get3Quest ();
		quest4 = MultiLanguageQuestScript.Get4Quest ();
		quest5 = MultiLanguageQuestScript.Get5Quest ();
		quest6 = MultiLanguageQuestScript.Get6Quest ();
		quest7 = MultiLanguageQuestScript.Get7Quest ();
		quest8 = MultiLanguageQuestScript.Get8Quest ();
		quest9 = MultiLanguageQuestScript.Get9Quest ();
		quest10 = MultiLanguageQuestScript.Get10Quest ();
		quest11 = MultiLanguageQuestScript.Get11Quest ();
		quest12 = MultiLanguageQuestScript.Get12Quest ();



		SetQuestion ();
	}

	private void SetQuestion() {
		switch(ActualSceneNunberScript.SceneNumber ()) {
		case 1:
			GetComponent<Text>().text = quest1;
			break;
		case 2:
			GetComponent<Text>().text = quest2;
			break;
		case 3:
			GetComponent<Text>().text = quest3;
			break;
		case 4:
			GetComponent<Text>().text = quest4;
			break;
		case 5:
			GetComponent<Text>().text = quest5;
			break;
		case 6:
			GetComponent<Text>().text = quest6;
			break;
		case 7:
			GetComponent<Text>().text = quest7;
			break;
		case 8:
			GetComponent<Text>().text = quest8;
			break;
		case 9:
			GetComponent<Text>().text = quest9;
			break;
		case 10:
			GetComponent<Text>().text = quest10;
			break;
		case 11:
			GetComponent<Text>().text = quest11;
			break;
		case 12:
			GetComponent<Text>().text = quest12;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
