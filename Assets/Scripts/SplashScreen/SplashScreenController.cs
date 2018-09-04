using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour {


	void Start () {
		StartCoroutine (LoadMainMenu ());

	}

	IEnumerator LoadMainMenu () {
	
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene (1);
	}
}
