using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieClick : MonoBehaviour
{


	public GameObject textBox;
	public  AudioSource audioCookie;
	public bool audioPlaying = false;

	public void ClickTheButton ()
	{

		GlobalCookies.cookieCount += 1;
		if (audioPlaying == false) {
			audioCookie.Play ();	
			StartCoroutine (AudioCookiePlaying());
			audioPlaying = true;
		}
		

	}

	IEnumerator AudioCookiePlaying() {
		yield return new WaitWhile (()=> audioCookie.isPlaying);
		audioPlaying = false;
	}
}

