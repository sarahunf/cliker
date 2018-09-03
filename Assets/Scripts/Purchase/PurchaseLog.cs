using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

	public GameObject autoCookie;

	public void StartAutoCookie () {
		autoCookie.SetActive (true);
		GlobalCash.cashCount -= GlobalBaker.bakerValue;
		GlobalBaker.bakerValue *= 2;
		GlobalBaker.turnOffBtn = true;
	}
}
