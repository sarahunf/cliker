using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterGenerator : MonoBehaviour {

	public GameObject statusBox;
	public float cookieCheck;
	public int genChance;
	public bool disasterActive = false;
	public int cookieLoss;

	void Update () {
		cookieCheck = GlobalCookies.cookieCount / 10; 								// muda a chance de desastre
		if (disasterActive == false) {
			StartCoroutine (StartDisaster ());
		}
	}

	IEnumerator StartDisaster() {
		disasterActive = true;
		genChance = Random.Range (1, 5);											 // muda a chance de desastre

		if (cookieCheck >= genChance) {
			cookieLoss = Mathf.RoundToInt (GlobalCookies.cookieCount * 0.25f);		 // muda a chance de desastre
			statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a fire";
			GlobalCookies.cookieCount -= cookieLoss;
			statusBox.GetComponent<Animation> ().Play ("StatusTextAnim");
			yield return new WaitWhile (() => statusBox.GetComponent<Animation> ().isPlaying);
			statusBox.SetActive (false);
			yield return new WaitForSeconds (1f);
			statusBox.SetActive (true);
		}
		yield return new WaitForSeconds (10f);
		disasterActive = false;
	}

}
