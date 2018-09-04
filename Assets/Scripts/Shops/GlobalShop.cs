using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour {

	public GameObject realBtn;
	public GameObject realBtnText;
	public GameObject fakeBtn;
	public GameObject fakeBtnText;
	public int currentCash;

	public static int cashMakerValue = 5;
	public static bool turnOffBtn = false;
	public GameObject casherStats;
	public static int numberOfCashers;
	public static int cashersPerSec;

	void Update ()
	{
		currentCash = GlobalCash.cashCount;
		casherStats.GetComponent<Text> ().text = "cashers: " + numberOfCashers + "/" + cashersPerSec + " per sec";
		fakeBtnText.GetComponent<Text> ().text = "Buy auto cash - $" + cashMakerValue;
		realBtnText.GetComponent<Text> ().text = "Buy auto cash - $" + cashMakerValue;

		if (currentCash >= cashMakerValue) {
			realBtn.SetActive (true);
			fakeBtn.SetActive (false);
		}
		if (turnOffBtn == true) {
			fakeBtn.SetActive (true);
			realBtn.SetActive (false);
			turnOffBtn = false;
		}
	}	
}
