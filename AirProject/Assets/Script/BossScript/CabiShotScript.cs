using UnityEngine;
using System.Collections;

public class CabiShotScript : MonoBehaviour {
	float senbeiSpeed = 0.5f;
	float waitTime = 0;
	int countBall = 0;

	void Start () {
		transform.LookAt(Vector3.zero);
	}

	void Update () {



		transform.Translate (0, 0, senbeiSpeed);

		waitTime += Time.deltaTime;

		if (waitTime >= 10f) {
			countBall++;
			if (countBall == 1) {
				Destroy (gameObject, .1f);
			}
		}
	}
}

