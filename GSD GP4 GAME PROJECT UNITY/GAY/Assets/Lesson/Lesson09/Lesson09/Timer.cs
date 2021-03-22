﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float myTimer=10;
	public Slider slider;

	Text text;

	void Start () {
		text = GetComponent<Text>();
		slider.maxValue = myTimer;
		slider.minValue = 0;
	}

	void Update () {
		if (myTimer > 0)
			myTimer -= Time.deltaTime;
		else {
			myTimer = 0;
		}
		slider.value = myTimer;
		text.text = (myTimer).ToString("00");
	}
}


