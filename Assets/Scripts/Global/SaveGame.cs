using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour {

	public GameObject saveBtn;

	public void SaveTheGame () {
		PlayerPrefs.SetInt ("SavedCookies", GlobalCookies.cookieCount);	
		PlayerPrefs.SetInt ("SavedCash", GlobalCash.cashCount);	
		PlayerPrefs.SetInt ("SavedBakers", GlobalBaker.bakerValue);	
		PlayerPrefs.SetInt ("SavedShops", GlobalShop.cashMakerValue);	
	
	}
}
