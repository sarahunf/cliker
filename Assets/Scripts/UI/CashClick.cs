using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashClick : MonoBehaviour
{
	public GameObject textBox;
	public GameObject statusBox;
	public AudioSource audioCash;
	public AudioSource audioCashOne;
	public AudioSource audioCashTwo;
	private int audiosRandom;

	public void ClickTheButton ()
	{
		audiosRandom = Random.Range (1, 4);

		if (GlobalCookies.cookieCount == 0) {
			statusBox.GetComponent<Text> ().text = "Not enough cookiezitos";
			statusBox.GetComponent<Animation> ().Play ("StatusTextAnim");
		} else {

				if (audiosRandom == 1) {
					audioCash.Play ();
			
				} else if (audiosRandom == 2) {
					audioCashOne.Play ();
			
				} else if (audiosRandom == 3) {
					audioCashTwo.Play ();
				}
			

			GlobalCookies.cookieCount -= 1;
			GlobalCash.cashCount += 1;
		}
	}
}
