using UnityEngine;
using System.Collections;

public class FairyMoveBoss : MonoBehaviour {

	public GameObject Camera;

	int maxCount = 100;
	int count = 0;

	int direction = 0;
	int directionCount = 0;

	float timer = 0;

	bool falyAngle = true;

	// Use this for initialization
	void Start () {
		falyAngle = true;
	}

	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer >= 7) {
			if (falyAngle) {
				this.transform.Rotate (new Vector3 (0f, -160f, 0f));
				falyAngle = false;
			}
		}

		if (!Oubetutorial.isMoving) {
			transform.LookAt( Camera.transform );
			//横移動
			directionCount++;
	
			if (directionCount <= 60 ) {
				transform.Translate (-0.05f, 0, 0);
			}
		}

		//縦移動
		count++;

		if (count < maxCount / 2) {
			transform.Translate (0, 0.007f, 0);
		} else if (count == maxCount) {

		} else {
			transform.Translate (0, -0.007f, 0);
		}

		if (count >= maxCount) {
			count = 0;
		}
	}
}
