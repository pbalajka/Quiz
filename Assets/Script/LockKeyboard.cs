using UnityEngine;
using System.Collections;

public class LockKeyboard : MonoBehaviour {
	public static void LockKey(){
		if(Utils.IsMobil())
			HideShowKeyboard.SetWait (true);
		else
			LoadCharFromKeyboard.SetWait (true);
	}

	public static void UnlockKey(){
		if(Utils.IsMobil())
			HideShowKeyboard.SetWait (false);
		else
			LoadCharFromKeyboard.SetWait (false);
	}
}