using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieClick : MonoBehaviour
{


	public GameObject textBox;
	public  AudioSource audioCookie;
	public bool audioPlaying = false;
	public GameObject filling;

	public int counter = 0; // lets start with zero



	void Update ()
	{	

		Rect bounds = new Rect (0, (Screen.height /2 ), Screen.width, (Screen.height/ 10));

	#if UNITY_EDITOR

		print ("height" + bounds.height);
		print ("width" + bounds.width);

	#elif UNITY_ANDROID

		int fingerCount = 0;

		Touch myTouch = Input.GetTouch (0);
		Touch[] myTouches = Input.touches;

		for (int i = 0; i < Input.touchCount; i++) {
		if (bounds.Contains (myTouch.position)) {
				ClickTheButton ();
		
			}

		}
		#endif
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(100,100,200,50), "Count: " + counter))
		{ // the IF is true = clicked, lets count one
			ClickTheButton (); 
		}
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

