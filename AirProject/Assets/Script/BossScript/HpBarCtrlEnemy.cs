using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpBarCtrlEnemy: MonoBehaviour {

	Slider _slider;

	public float hitBall;

	void Start () {
	    
		// スライダーを取得する
		_slider = GameObject.Find("EnemySlider").GetComponent<Slider>();
	}

	float _hp = 0;
	void Update () {
		hitBall = EffectScript.hitBall;

		_hp = _slider.maxValue - hitBall;

		// HPゲージに値を設定
		_slider.value = _hp;
	}
}