using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour {

	public bool creatingCookie;
	public static int cookieIncrease = 1;
	public int internalCookieIncrease;


	void Update () {
		cookieIncrease = GlobalBaker.bakersPerSec;
		internalCookieIncrease = cookieIncrease;
		if (creatingCookie == false) {
			creatingCookie = true;
			StartCoroutine (CreateTheCookie());
		}

	}

	IEnumerator CreateTheCookie () {
		GlobalCookies.cookieCount += internalCookieIncrease;
		yield return new WaitForSeconds (0.9f);
		creatingCookie = false;
	}
}
