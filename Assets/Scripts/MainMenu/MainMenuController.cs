using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public static bool gameIsLoadead = false;

	public void NewGame() {
		SceneManager.LoadScene (2);
	}

	public void LoadGame() {
		gameIsLoadead = true; 
		SceneManager.LoadScene (2);
	}
}
