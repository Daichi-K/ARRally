using UnityEngine;
using System.Collections;

public class EnemyShotControll : MonoBehaviour {

	public GameObject enemyball;
	public GameObject monoAttaclVoice;

	public Vector3 placePosition;
	Quaternion q = new Quaternion();

	float waitTime = 0;

	// Use this for initialization
	void Start () {
		q = this.transform.rotation;
	}

	// Update is called once per frame
	void Update () {

		if (EffectScript.hitBall < 30) {
			
			waitTime += 1;

			placePosition = this.transform.position;

			if (waitTime == 80) {
				monoAttaclVoice.SetActive (false);
			}

			//通常１０秒
			if (EffectScript.hitBall >= 0 && EffectScript.hitBall < 4) {
				if (waitTime == 520) {	//-100
					monoAttaclVoice.SetActive (true);
				}
				if (waitTime == 600) {
					//enemyball = (GameObject) Instantiate(enemyball,placePosition,q);
					Instantiate (enemyball, placePosition, q);
					waitTime = 0;
				}
			}
			//火水　８秒
			if (EffectScript.hitBall >= 4 && EffectScript.hitBall < 14) {
				if (waitTime == 400) {	//-100
					monoAttaclVoice.SetActive (true);
				}
				if (waitTime == 480) {
					//enemyball = (GameObject) Instantiate(enemyball,placePosition,q);
					Instantiate (enemyball, placePosition, q);
					waitTime = 0;
				}
			}
			//土雷　６秒
			if (EffectScript.hitBall >= 14 && EffectScript.hitBall < 24) {
				if (waitTime == 280) {	//-100
					monoAttaclVoice.SetActive (true);
				}
				if (waitTime == 360) {
					//enemyball = (GameObject) Instantiate(enemyball,placePosition,q);
					Instantiate (enemyball, placePosition, q);
					waitTime = 0;
				}
			}
			//怒り　４秒
			if (EffectScript.hitBall >= 4 && EffectScript.hitBall < 9) {
				if (waitTime == 200) {	//-100
					monoAttaclVoice.SetActive (true);
				}
				if (waitTime == 280){
					//enemyball = (GameObject) Instantiate(enemyball,placePosition,q);
					Instantiate (enemyball, placePosition, q);
					waitTime = 0;
				}
			}
		}
	}
}
