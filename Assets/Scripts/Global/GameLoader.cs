using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

	public int savedCookies;
	public int savedCash;
	public int savedBakers;
	public  int savedShop;

	void Awake () {
		savedCookies = PlayerPrefs.GetInt ("SavedCookies", GlobalCookies.cookieCount);
		GlobalCookies.cookieCount = savedCookies;
		savedCash = PlayerPrefs.GetInt ("SavedCash", GlobalCash.cashCount);
		GlobalCash.cashCount = savedCash;
		savedBakers = PlayerPrefs.GetInt ("SavedBakers", GlobalBaker.bakerValue);
		GlobalBaker.bakerValue = savedBakers;
		savedShop = PlayerPrefs.GetInt ("SavedShops", GlobalShop.cashMakerValue);
		GlobalShop.cashMakerValue = savedShop;

	}
}
