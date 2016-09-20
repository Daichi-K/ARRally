using UnityEngine;
using System.Collections;

public class CollisionPlayer : MonoBehaviour {

	public GameObject dmgUI;
	public GameObject redWall;
	public GameObject Gameover;
	public GameObject winkVoiceSry;
	public GameObject monoWarau;

	bool hitDmg = false;

	int filedCount = 0;
	int hitCount = 0;
	public static float hitBall = 0;

	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag ("Enemy")) {
			hitBall += 2;
			hitDmg = true;
		}
	}

	void Update () {
		if (hitBall >= 34 ) {
			filedCount++;
		}

		if (filedCount == 1) {
			redWall.SetActive ( true );
			monoWarau.SetActive (true);
		}
		if (filedCount == 500) {
			Gameover.SetActive ( true );
			winkVoiceSry.SetActive (true);
		}

		if (filedCount >= 800) {
			Application.LoadLevel ("bossResult_kin");
			//EffectScript.hitBall = 0;
			//hitBall = 0;
		}

		//敵のたまに当たった
		if (hitDmg) {
			dmgUI.SetActive ( true );
			hitCount++;
		}
		if (hitCount >= 40) {
			dmgUI.SetActive ( false );
			hitCount = 0;
			hitDmg = false;
		}
	}
}
