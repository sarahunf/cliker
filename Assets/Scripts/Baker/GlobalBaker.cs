using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
	public GameObject realBtn;
	public GameObject realBtnText;
	public GameObject fakeBtn;
	public GameObject fakeBtnText;
	public int currentCash;

	public static int bakerValue = 20;
	public static bool turnOffBtn = false;

	void Update ()
	{
		currentCash = GlobalCash.cashCount;
		fakeBtnText.GetComponent<Text> ().text = "Buy auto - $" + bakerValue;
		realBtnText.GetComponent<Text> ().text = "Buy auto - $" + bakerValue;

		if (currentCash >= bakerValue) {
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
