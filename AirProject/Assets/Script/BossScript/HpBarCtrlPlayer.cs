﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpBarCtrlPlayer: MonoBehaviour {

	Slider _slider;
	public float hitBall;

	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("MySlider").GetComponent<Slider>();
	}

	float _hp = 0;
	void Update () {
		_slider = GameObject.Find("MySlider").GetComponent<Slider>();

		hitBall = CollisionPlayer.hitBall;

		_hp = _slider.maxValue - hitBall;


		// HPゲージに値を設定
		_slider.value = _hp;

		_slider.maxValue = 34;
	}
}