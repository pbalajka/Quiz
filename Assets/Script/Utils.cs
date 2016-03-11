using UnityEngine;
using System.Collections;

public class Utils : MonoBehaviour {

	public static bool IsMobil() {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
			return true;
		else
			return false;
	}
}