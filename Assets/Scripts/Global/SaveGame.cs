using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour {

	public GameObject saveBtn;
	public static bool gameIsLoadead = false;

	public void SaveTheGame () {
		PlayerPrefs.SetInt ("SavedCookies", GlobalCookies.cookieCount);	
		PlayerPrefs.SetInt ("SavedCash", GlobalCash.cashCount);	
		PlayerPrefs.SetInt ("SavedBakers", GlobalBaker.bakerValue);	
		PlayerPrefs.SetInt ("SavedShops", GlobalShop.cashMakerValue);

		PlayerPrefs.SetInt ("SavedNumOfBakers", GlobalBaker.numberOfBakers);	
		PlayerPrefs.SetInt ("SavedBakersPerSec", GlobalBaker.bakersPerSec);	
		PlayerPrefs.SetInt ("SavedNumOfShopers", GlobalShop.numberOfShopers);	
		PlayerPrefs.SetInt ("SavedShopersPerSec", GlobalShop.shopersPerSec);

		gameIsLoadead = true;

	
	}
}
