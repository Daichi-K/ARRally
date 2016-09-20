using UnityEngine;
using System.Collections;

namespace Vuforia {
public class BossControll : MonoBehaviour {

	public GameObject Boss;

	public float timer = 0;

	int rand = 0;

	float bossScale = 0;

	Vector3 pos1 = new Vector3( 0, -0.9f, -50);
	Vector3 pos2 = new Vector3( 0, -0.9f,  50);
	Vector3 pos3 = new Vector3( -50, -0.9f, 0);
	Vector3 pos4 = new Vector3( 50, -0.9f, 0);

	// Use this for initialization
	void Start () {
			timer = 250;
			bossScale = 300;
	}
	
	// Update is called once per frame
	void Update () {
			if ( EffectScript.hitBall >= 4) {

				if (StartEvent.isStart) {
					timer += 1;
					rand = Random.Range (1, 5);
					Boss.transform.localScale = new Vector3 (bossScale, bossScale, bossScale);

					//大きさ制限
					if (bossScale <= 0) {
						bossScale = 0;
					}
					if (bossScale >= 300) {
						bossScale = 300;
					}

					//ボステレポート処理
					if (timer / 60 < 3) {
						bossScale += 10;
					} 
					if (timer / 60 >= 14 && timer / 60 < 17) {
						Boss.SetActive (false);
					}

					if (timer / 60 >= 13) {
						bossScale -= 10;
					}

					if (timer / 60 == 17) {
						Boss.SetActive (true);
						if (rand == 1) {
							Boss.transform.position = pos1;
						} else if (rand == 2) {
							Boss.transform.position = pos2;
						} else if (rand == 3) {
							Boss.transform.position = pos3;
						} else if (rand == 4) {
							Boss.transform.position = pos4;
						}
						timer = 0;
					}
				}
			}
		}
	}
}