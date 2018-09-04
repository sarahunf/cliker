using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCash : MonoBehaviour {

	public bool SellingCookie;
	public static int cashIncrease = 1;
	public int internalCashIncrease;


	void Update () {
		cashIncrease = GlobalShop.cashersPerSec;
		internalCashIncrease = cashIncrease;
		if (SellingCookie == false) {
			SellingCookie = true;
			StartCoroutine (SellTheCookie());
		}

	}

	IEnumerator SellTheCookie () {
		GlobalCash.cashCount += internalCashIncrease;
		yield return new WaitForSeconds (0.9f);
		SellingCookie = false;
	}


	//
//	public bool creatingCash;
//	public static int cashIncrease = 1;
//	public int internalCashIncrease;
//
//
//	void Update () {
//		internalCashIncrease = cashIncrease;
//		if (creatingCash == false) {
//			creatingCash = true;
//			StartCoroutine (CreateTheCookie());
//		}
//
//	}
//
//	IEnumerator CreateTheCookie () {
//		GlobalCookies.cookieCount += internalCashIncrease;
//		yield return new WaitForSeconds (0.9f);
//		creatingCash = false;
//	}
}
