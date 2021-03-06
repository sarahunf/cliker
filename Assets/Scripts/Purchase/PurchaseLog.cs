﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

	public PurchaseLog instance;

	public GameObject autoCookie;
	public GameObject autoCash;

	void Awake () {
		instance = this;
	}


	void Start () {
		if (PlayerPrefs.HasKey ("SavedBakers")) {
				autoCookie.SetActive (true);

		} else if (PlayerPrefs.HasKey ("SavedShops")) {
			autoCash.SetActive (true);
		}
	}


	public void StartAutoCookie () {
		autoCookie.SetActive (true);
		GlobalCash.cashCount -= GlobalBaker.bakerValue;
		GlobalBaker.bakerValue *= 2;
		GlobalBaker.turnOffBtn = true;
		GlobalBaker.bakersPerSec += 1;
		GlobalBaker.numberOfBakers += 1;

	}


	public void StartAutoShop () {
		autoCash.SetActive (true);
		GlobalCash.cashCount -= GlobalShop.cashMakerValue;
		GlobalShop.cashMakerValue *= 2;
		GlobalShop.turnOffBtn = true;
		GlobalShop.shopersPerSec += 1;
		GlobalShop.numberOfShopers += 1;

	}
}
