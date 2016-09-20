using UnityEngine;
using System.Collections;

public class TargetRotation : MonoBehaviour {
	int maxCount = 500;
	int count = 0;
	float speed = 0.5f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < maxCount / 3.85; i++) {
			transform.Translate (-0.4f, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Vector3.zero);

		//通常
		if (EffectScript.hitBall >= 0 && EffectScript.hitBall < 4) {
			speed = 0.2f;
		}
		//火水　８秒
		if (EffectScript.hitBall >= 4 && EffectScript.hitBall < 14) {
			speed = 0.4f;
		}
		//土雷　６秒
		if (EffectScript.hitBall >= 14 && EffectScript.hitBall < 24) {
			speed = 0.5f;
		}
		//怒り　４秒
		if (EffectScript.hitBall >= 4 && EffectScript.hitBall < 9) {
			speed = 0.6f;
		}


		count++;
		if (EffectScript.hitBall < 30) {
			if (count < maxCount / 2) {
				transform.Translate (speed, 0, 0);
			} else if (count == maxCount) {
			
			} else {
				transform.Translate (-speed, 0, 0);
			}

			if (count >= maxCount) {
				count = 0;
			}
		}
	}
}
