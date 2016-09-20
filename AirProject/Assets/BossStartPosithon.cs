using UnityEngine;
using System.Collections;

public class BossStartPosithon : MonoBehaviour {

	int count = 0;
	float bossScale = 0;
	public float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3 (bossScale, bossScale, bossScale);

		timer += 1;

		if (bossScale <= 0) {
			bossScale = 0;
		}
		if (bossScale >= 300) {
			bossScale = 300;
		}

		if (count <= 75) {
			transform.Translate ( 0, 0, 0.4f);
			count++;
		}

		if (timer / 60 < 2) {
			bossScale += 10;
		} 

		if (timer / 60 >= 6) {
			bossScale -= 10;
		}
	}
}
