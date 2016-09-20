using UnityEngine;
using System.Collections;

public class Oubetutorial : MonoBehaviour {
	float senbeiSpeed = 0.5f;
	float waitTime = 0;
	int countBall = 0;

	public static bool isMoving = true;

	void Start () {
		transform.LookAt(Vector3.zero);
		isMoving = true;
	}

	void Update () {
		if( isMoving ) {
			transform.Translate (0, 0, senbeiSpeed);
		}
		waitTime += Time.deltaTime;

		if (waitTime >= 1.3f && waitTime <= 4.0 ) {
			isMoving = false;
		}
		if (waitTime >= 6.3f) {
			isMoving = true;
		}

		/*if (waitTime >= 10f) {
			countBall++;
			if (countBall == 1) {
				Destroy (gameObject, .1f);
			}
		}*/
	}
}

