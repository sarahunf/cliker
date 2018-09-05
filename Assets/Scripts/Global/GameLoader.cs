using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

	public int savedCookies;
	public int savedCash;
	public int savedBakers;
	public int savedShop;

	public int savedNumOfBakers;
	public int savedBakersPerSec;
	public int savedNumOfCashers;
	public int savedShopersPerSec;

	public GameObject savedAutoCookie;
	public GameObject savedAutoShop;

	void Awake () {
		if (MainMenuController.gameIsLoadead == true) {
			savedCookies = PlayerPrefs.GetInt ("SavedCookies", GlobalCookies.cookieCount);
			GlobalCookies.cookieCount = savedCookies;
			savedCash = PlayerPrefs.GetInt ("SavedCash", GlobalCash.cashCount);
			GlobalCash.cashCount = savedCash;
			savedBakers = PlayerPrefs.GetInt ("SavedBakers", GlobalBaker.bakerValue);
			GlobalBaker.bakerValue = savedBakers;
			savedShop = PlayerPrefs.GetInt ("SavedShops", GlobalShop.cashMakerValue);
			GlobalShop.cashMakerValue = savedShop;

			savedNumOfBakers = 	PlayerPrefs.GetInt ("SavedNumOfBakers", GlobalBaker.numberOfBakers);
			GlobalBaker.numberOfBakers = savedNumOfBakers;
			savedBakersPerSec = PlayerPrefs.GetInt ("SavedBakersPerSec", GlobalBaker.bakersPerSec);	
			GlobalBaker.bakersPerSec = savedBakersPerSec;
			savedNumOfCashers = PlayerPrefs.GetInt ("SavedNumOfShopers", GlobalShop.numberOfShopers);	
			GlobalShop.numberOfShopers = savedNumOfCashers;
			savedShopersPerSec = PlayerPrefs.GetInt ("SavedShopersPerSec", GlobalShop.shopersPerSec);
			GlobalShop.shopersPerSec = savedShopersPerSec;
		}
	}

	void Start () {
		if (savedCash >= savedBakers){
			savedAutoCookie.SetActive (true);
		
		} else if(savedCash >= savedShop ) {
			savedAutoShop.SetActive (true);
		}
	}
}
