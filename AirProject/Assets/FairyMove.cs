using UnityEngine;
using System.Collections;

public class FairyMove : MonoBehaviour {

	public GameObject Camera;

	int maxCount = 100;
	int count = 0;

	int direction = 0;
	int directionCount = 0;
	int directionMaxCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.LookAt( Camera.transform );
		//横移動
		/*directionCount++;

		if (directionCount >= directionMaxCount ) {
			direction = Random.Range ( 0, 3 );
			directionMaxCount = Random.Range ( 180, 300 );
			directionCount = 0;
		}

		if (direction == 0) {
			transform.Translate (0.015f, 0, 0);
		} else if (direction == 1) {
			transform.Translate (-0.015f, 0, 0);
		} else if (direction == 2) {
		
		}*/

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
