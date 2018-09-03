using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashClick : MonoBehaviour
{


	public GameObject textBox;
	public GameObject statusBox;

	public void ClickTheButton ()
	{

		if (GlobalCookies.cookieCount == 0) {
			statusBox.SetActive (true);
			statusBox.GetComponent<Text> ().text = "Not enough cookiezitos";
			statusBox.GetComponent<Animation> ().Play ("StatusTextAnim");
		} else {
			GlobalCookies.cookieCount -= 1;
			GlobalCash.cashCount += 1;
		}
	}
}
