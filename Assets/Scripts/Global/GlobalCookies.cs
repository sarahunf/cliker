using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour {

	public static int cookieCount;
	public int internalCookie;
	public GameObject cookieDisplay;


	void Update () {

		internalCookie = cookieCount;
		cookieDisplay.GetComponent<Text>().text = "Cookiezitos: " + internalCookie;

	}
}
