using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCash : MonoBehaviour
{

	public bool SellingCookie;
	public static int cashIncrease = 1;
	public int internalCashIncrease;
	public int internalCookieIncrease;


	void Update ()
	{
		internalCookieIncrease = GlobalCookies.cookieCount;
		cashIncrease = GlobalShop.shopersPerSec;
		internalCashIncrease = cashIncrease;
		if (internalCookieIncrease >= 0) {
			if (SellingCookie == false) {
				SellingCookie = true;
				StartCoroutine (SellTheCookie ());
			}
		}

	}

	IEnumerator SellTheCookie ()
	{
		GlobalCookies.cookieCount -= Mathf.RoundToInt (internalCashIncrease*0.5f);
			GlobalCash.cashCount += internalCashIncrease;
			yield return new WaitForSeconds (0.9f);
			SellingCookie = false;
	}
		
}
