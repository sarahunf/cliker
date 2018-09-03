using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour {

	public static int cashCount;
	public int internalCash;
	public GameObject cashDisplay;


	void Update () {

		internalCash = cashCount;
		cashDisplay.GetComponent<Text>().text = "$ " + internalCash;

	}
}
