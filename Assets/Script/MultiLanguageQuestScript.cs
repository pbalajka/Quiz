using UnityEngine;
using System.Collections;

public class MultiLanguageQuestScript : MonoBehaviour {
	//Anglicke otazky
	private static string quest1ENG ="How do you say love in Czech?";
	private static string quest2ENG ="How do you say joy in Spanish?";
	private static string quest3ENG ="How do you say luck in Italian?";
	private static string quest4ENG ="How do you say beauty in Portuguese?";
	private static string quest5ENG ="How do you say hope in Russian?";
	private static string quest6ENG ="How do you say aesthetics in French?";
	private static string quest7ENG ="How do you say beautiful in Slovak?";
	private static string quest8ENG ="How do you say I love you in Spanish?";
	private static string quest9ENG ="How do you say I love you in Italian?";
	private static string quest10ENG ="How do you say I love you in Portuguese?";
	private static string quest11ENG ="How do you say God in Russian?";
	private static string quest12ENG ="How do you say creator in Slovak?";
	//Talianske otazky
	private static string quest1IT ="Come si dice amore di inglese ?";
	private static string quest2IT ="Come si dice di spagnolo piacere ?";
	private static string quest3IT ="Come si dice felicità di ceco ?";
	private static string quest4IT ="Come si dice bellezza di portoghese ?";
	private static string quest5IT ="Come si dice spero di russo ?";
	private static string quest6IT ="Come si dice estetica di francese ?";
	private static string quest7IT ="Come si dice bella di inglese ?";
	private static string quest8IT ="Come si dice ti amo di spagnolo ?";
	private static string quest9IT ="Come dite che io amo di lingua slovacca ?";
	private static string quest10IT ="Come si dice ti amo di portoghese ?";
	private static string quest11IT ="Come faccio a dire che Dio di russo ?";
	private static string quest12IT ="Come si dice Creatore di slovacco?";
	//Spanielske otazky
	private static string quest1ESP ="¿Cómo se dice el  amor en inglés ?";
	private static string quest2ESP ="¿Cómo puedo decir la alegría en checo?";
	private static string quest3ESP ="¿Cómo se dice  la  suerte en italiano?";
	private static string quest4ESP ="¿Cómo se dice la  belleza en portugués?";
	private static string quest5ESP ="¿Cómo se dice la  esperanza en ruso?";
	private static string quest6ESP ="¿Cómo se dice la estética en francés ?";
	private static string quest7ESP ="¿Cómo se dice bello en inglés ?";
	private static string quest8ESP ="¿Cómo se dice te amo  en eslovaco ?";
	private static string quest9ESP ="¿Cómo se dice me  quiero en  italiano?";
	private static string quest10ESP ="¿Cómo se dice te quiero en portugués ?";
	private static string quest11ESP ="¿Cómo se dice   el  Dios en  ruso?";
	private static string quest12ESP ="¿Cómo se dice  el Creador en eslovaco ?";
	//Portugalske otazky
	private static string quest1PT ="Como você diz amor em Inglês ?";
	private static string quest2PT ="Como você diz prazer em espanhol?";
	private static string quest3PT ="Como você diz boa sorte em italiano ?";
	private static string quest4PT ="Como você diz beleza em tcheco ?";
	private static string quest5PT ="Como você diz espero em russo ?";
	private static string quest6PT ="Como você diz estética em francês ?";
	private static string quest7PT ="Como você diz bom em Inglês ?";
	private static string quest8PT ="Como você diz eu te amo, Você fala espanhol?";
	private static string quest9PT ="Como você diz eu te amo em italiano ?";
	private static string quest10PT ="Como você diz eu te amo em Eslovaco ?";
	private static string quest11PT ="Como você diz Deus em russo ?";
	private static string quest12PT ="Como você diz o Criador em Eslovaco?";
	//Ruske otazky
	private static string quest1RU ="Как скажeтcя, любви на английском языке ?";
	private static string quest2RU ="Как скажeтcя, удовольствие на испанском языке ?";
	private static string quest3RU ="Как скажeтcя, удачи на итальянском языке ?";
	private static string quest4RU ="Как скажeтcя, красоту на португальском языке ?";
	private static string quest5RU ="Как скажeтcя, надеюсь, словацкий язык ?";
	private static string quest6RU ="Как скажeтcя, эстетика на французском языке?";
	private static string quest7RU ="Как скажeтcя, хороший на английскoм языкe ?";
	private static string quest8RU ="Как скажeтcя, я тебя люблю говорить на испанском языке?";
	private static string quest9RU ="Как скажeтcя, что я люблю себя по-итальянски?";
	private static string quest10RU ="Как скажeтcя, люблю тебя на португальском языке?";
	private static string quest11RU ="Как скажeтcя, бог на чешскoм языкe ?";
	private static string quest12RU ="Как скажeтcя, творца на словацкoм языкe ?";

	//Error
	private static string errorENG = "Error, do not load message";

	public static string Get1Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest1ENG;
		case EnumLanguagesScript.Language.IT:
			return quest1IT;
		case EnumLanguagesScript.Language.ESP:
			return quest1ESP;
		case EnumLanguagesScript.Language.PT:
			return quest1PT;
		case EnumLanguagesScript.Language.RU:
			return quest1RU;
		default :
			return errorENG;
		}
	}

	public static string Get2Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest2ENG;
		case EnumLanguagesScript.Language.IT:
			return quest2IT;
		case EnumLanguagesScript.Language.ESP:
			return quest2ESP;
		case EnumLanguagesScript.Language.PT:
			return quest2PT;
		case EnumLanguagesScript.Language.RU:
			return quest2RU;
		default :
			return errorENG;
		}
	}

	public static string Get3Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest3ENG;
		case EnumLanguagesScript.Language.IT:
			return quest3IT;
		case EnumLanguagesScript.Language.ESP:
			return quest3ESP;
		case EnumLanguagesScript.Language.PT:
			return quest3PT;
		case EnumLanguagesScript.Language.RU:
			return quest3RU;
		default :
			return errorENG;
		}
	}

	public static string Get4Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest4ENG;
		case EnumLanguagesScript.Language.IT:
			return quest4IT;
		case EnumLanguagesScript.Language.ESP:
			return quest4ESP;
		case EnumLanguagesScript.Language.PT:
			return quest4PT;
		case EnumLanguagesScript.Language.RU:
			return quest4RU;
		default :
			return errorENG;
		}
	}

	public static string Get5Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest5ENG;
		case EnumLanguagesScript.Language.IT:
			return quest5IT;
		case EnumLanguagesScript.Language.ESP:
			return quest5ESP;
		case EnumLanguagesScript.Language.PT:
			return quest5PT;
		case EnumLanguagesScript.Language.RU:
			return quest5RU;
		default :
			return errorENG;
		}
	}
		public static string Get6Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest6ENG;
		case EnumLanguagesScript.Language.IT:
			return quest6IT;
		case EnumLanguagesScript.Language.ESP:
			return quest6ESP;
		case EnumLanguagesScript.Language.PT:
			return quest6PT;
		case EnumLanguagesScript.Language.RU:
			return quest6RU;
		default :
			return errorENG;
		}
	}

	public static string Get7Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest7ENG;
		case EnumLanguagesScript.Language.IT:
			return quest7IT;
		case EnumLanguagesScript.Language.ESP:
			return quest7ESP;
		case EnumLanguagesScript.Language.PT:
			return quest7PT;
		case EnumLanguagesScript.Language.RU:
			return quest7RU;
		default :
			return errorENG;
		}
	}

	public static string Get8Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest8ENG;
		case EnumLanguagesScript.Language.IT:
			return quest8IT;
		case EnumLanguagesScript.Language.ESP:
			return quest8ESP;
		case EnumLanguagesScript.Language.PT:
			return quest8PT;
		case EnumLanguagesScript.Language.RU:
			return quest8RU;
		default :
			return errorENG;
		}
	}
		public static string Get9Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest9ENG;
		case EnumLanguagesScript.Language.IT:
			return quest9IT;
		case EnumLanguagesScript.Language.ESP:
			return quest9ESP;
		case EnumLanguagesScript.Language.PT:
			return quest9PT;
		case EnumLanguagesScript.Language.RU:
			return quest9RU;
		default :
			return errorENG;
		}
	}
		public static string Get10Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest10ENG;
		case EnumLanguagesScript.Language.IT:
			return quest10IT;
		case EnumLanguagesScript.Language.ESP:
			return quest10ESP;
		case EnumLanguagesScript.Language.PT:
			return quest10PT;
		case EnumLanguagesScript.Language.RU:
			return quest10RU;
		default :
			return errorENG;
		}
	}

	public static string Get11Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest11ENG;
		case EnumLanguagesScript.Language.IT:
			return quest11IT;
		case EnumLanguagesScript.Language.ESP:
			return quest11ESP;
		case EnumLanguagesScript.Language.PT:
			return quest11PT;
		case EnumLanguagesScript.Language.RU:
			return quest11RU;
		default :
			return errorENG;
		}
	}
		public static string Get12Quest() {
		switch (EnumLanguagesScript.GetLanguage ()) {
		case EnumLanguagesScript.Language.ENG:
			return quest12ENG;
		case EnumLanguagesScript.Language.IT:
			return quest12IT;
		case EnumLanguagesScript.Language.ESP:
			return quest12ESP;
		case EnumLanguagesScript.Language.PT:
			return quest12PT;
		case EnumLanguagesScript.Language.RU:
			return quest12RU;
		default :
			return errorENG;
		}
	}
}