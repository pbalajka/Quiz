using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetQuestionScript : MonoBehaviour {

	void Start () {
		SetQuestion ();
	}

	private void SetQuestion() {
		switch(ActualSceneNunberScript.SceneNumber ()) {
		case 1:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get1Quest ();
			break;
		case 2:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get2Quest ();
			break;
		case 3:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get3Quest ();
			break;
		case 4:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get4Quest ();
			break;
		case 5:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get5Quest ();
			break;
		case 6:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get1Quest ();
			break;
		case 7:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get7Quest ();
			break;
		case 8:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get8Quest ();
			break;
		case 9:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get9Quest ();
			break;
		case 10:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get10Quest ();
			break;
		case 11:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get11Quest ();
			break;
		case 12:
			GetComponent<Text>().text = MultiLanguageQuestScript.Get12Quest ();
			break;
		}
	}
}