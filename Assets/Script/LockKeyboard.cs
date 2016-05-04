using UnityEngine;
using System.Collections;

public class LockKeyboard : MonoBehaviour {
	public static void LockKey(){
		if (Utils.IsMobil ()) {
			HideShowKeyboard.SetWait (true);
			HideShowKeyboard.LockButtonKeybort ();
		} else {
			LoadCharFromKeyboard.SetWait (true);
		}
	}

	public static void UnlockKey(){
		if (Utils.IsMobil ()) {
			HideShowKeyboard.SetWait (false);
			HideShowKeyboard.UnLockButtonKeybort ();
		} else {
			LoadCharFromKeyboard.SetWait (false);
		}
	}
}