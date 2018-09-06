using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieClick : MonoBehaviour
{


	public GameObject textBox;
	public  AudioSource audioCookie;
	public bool audioPlaying = false;

	void Update ()
	{	
		#if UNITY_EDITOR
		Debug.Log("Unity Editor");

		#elif UNITY_ANDROID
		Rect bounds = new Rect (0, 0, Screen.width, Screen.height / 2);
		//Touch[] myTouches = Input.touches;

		Touch myTouch = Input.GetTouch (0);
		for (int i = 0; i < Input.touchCount; i++) {
			if (bounds.Contains (myTouch.position)) {
				ClickTheButton ();
		
			}

		}
		#endif
	}


	public void ClickTheButton ()
	{
		GlobalCookies.cookieCount += 1;
		if (audioPlaying == false) {
			StartCoroutine (AudioCookiePlaying ());
			audioPlaying = true;
		}
	}

	IEnumerator AudioCookiePlaying ()
	{
		audioCookie.Play ();
		yield return new WaitWhile (() => audioCookie.isPlaying);
		audioPlaying = false;
	}
}

