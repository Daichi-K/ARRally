using UnityEngine;
using System.Collections;

public class EffectScript : MonoBehaviour {
	public GameObject ikari;
	public GameObject OubeController;
	public GameObject PosithonController;

	public GameObject bigbang1;
	public GameObject bigbang2;
	public GameObject bigbang3;
	public GameObject bigbang4;
    public GameObject attack;
	public GameObject clearUI;
	public GameObject darkMist;

	public GameObject bossNomal;
	public GameObject bossFire;
	public GameObject bossWater;
	public GameObject bossThunder;
	public GameObject bossSoil;
	public GameObject bossHonki;

	public GameObject BossMarkFire;
	public GameObject BossMarkWater;
	public GameObject BossMarkSoil;
	public GameObject BossMarkThunder;
	public GameObject BossMarkHonki;

	public GameObject winkClearVoice;
	public GameObject monoDie;

	public GameObject monoDamage1;
	public GameObject monoDamage2;
	public GameObject monoDamage3;
	public GameObject monoDamage4;

	public GameObject monoVoiceStyleChange1;
	public GameObject monoVoiceStyleChange2;
	public GameObject monoVoiceStyleChange3;
	public GameObject monoVoiceStyleChange4;

	int randomMonoVoice = 0;
	bool monoDamageVoiceSwitch = false;
	int monoCount = 0;

	int count = 0;
	bool bangSwitch = false;
	public static float hitBall = 0;
	int time = 0;

    bool isAttack = false;
    int attackCount = 0;

	//ボス属性形態
	int StayleCount = 0;
	int randBossStyle;

	public static bool farstBossStyle1 = true;
	public static bool farstBossStyle2 = true;
	public static bool farstBossStyle3 = true;
	public static bool farstBossStyle4 = true;
	public static bool farstBossStyle5 = true;
	public static bool tutorialWater = false;

	string test;

	void Start(){
		farstBossStyle1 = true;
		farstBossStyle2 = true;
		farstBossStyle3 = true;
		farstBossStyle4 = true;
		farstBossStyle5 = true;
		bossNomal.SetActive (true);
	}
		
	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Player")) {
			bangSwitch = true;	
			Debug.Log (randBossStyle);
			Debug.Log (col.gameObject.name);

			//弱点攻撃
			if (randBossStyle == 1) {	//炎
				if (col.gameObject.name == "PlayerOubeWater") {
					hitBall += 2.5f;
					tutorialWater = true;
				}
			}
			if (randBossStyle == 3) {	//雷
				if (col.gameObject.name == "PlayerOubeSoil") {
					hitBall += 2.5f;
				}
			}
			if (randBossStyle == 2) {	//水
				if (col.gameObject.name == "PlayerOubeThunder") {
					hitBall += 2.5f;
				}
			}
			if (randBossStyle == 4) {	//土
				if (col.gameObject.name == "PlayerOubeFire") {
					hitBall += 2.5f;
				}
			}
				
			hitBall += 3.5f;
			Debug.Log (col.gameObject.name);

            attack.gameObject.SetActive(true);
            isAttack = true;

			randomMonoVoice = Random.Range (1, 5);
			if (randomMonoVoice == 1) {
				monoDamage1.SetActive (true);
				monoDamageVoiceSwitch = true;
			} else if (randomMonoVoice == 2) {
				monoDamage2.SetActive (true);
				monoDamageVoiceSwitch = true;
			} else if (randomMonoVoice == 3) {
				monoDamage3.SetActive (true);
				monoDamageVoiceSwitch = true;
			} else if (randomMonoVoice == 4) {
				monoDamage4.SetActive (true);
				monoDamageVoiceSwitch = true;
			}
		}	
	}

	void Update () {
		//属性変化
		//火
		if( hitBall >= 4 && hitBall < 9 ) {
			if (farstBossStyle1) {
				bossFire.SetActive (true);
				BossMarkFire.SetActive (true);
				Destroy (bossNomal);
				monoVoiceStyleChange1.SetActive (true);
				farstBossStyle1 = false;
			}
		}
		//水
		if (hitBall >= 9 && hitBall < 14  ) {
			if (farstBossStyle2) {
				Destroy (bossFire);
				BossMarkFire.SetActive (false);
				bossWater.SetActive (true);
				BossMarkWater.SetActive (true);
				monoVoiceStyleChange2.SetActive (true);
				farstBossStyle2 = false;
			}
		}
		//土
		if (hitBall >= 14 && hitBall < 19 ) {
			if (farstBossStyle3) {
				Destroy (bossWater);
				BossMarkWater.SetActive (false);
				bossSoil.SetActive (true);
				BossMarkSoil.SetActive (true);
				monoVoiceStyleChange4.SetActive (true);
				farstBossStyle3 = false;
			}
		}
		//雷
		if (hitBall >= 19 && hitBall < 24 ) {
			if (farstBossStyle4) {
				Destroy (bossSoil);
				BossMarkSoil.SetActive (false);
				bossThunder.SetActive (true);
				BossMarkThunder.SetActive (true);
				monoVoiceStyleChange3.SetActive (true);
				farstBossStyle4 = false;
			}
		}
		//怒り
		if( hitBall >= 24 ) {
			if (farstBossStyle5) {
				Destroy (bossThunder);
				BossMarkThunder.SetActive (false);
				bossHonki.SetActive (true);
				BossMarkHonki.SetActive (true);
				farstBossStyle5 = false;
			}
			monoVoiceStyleChange2.SetActive (true);
		}

		//モノクロダメージ受けたときの後処理
		if (monoDamageVoiceSwitch) {
			monoCount++;
		}
		if (monoCount >= 70) {
			monoDamage1.SetActive (false);
			monoDamage2.SetActive (false);
			monoDamage3.SetActive (false);
			monoDamage4.SetActive (false);
			monoDamageVoiceSwitch = false;
			monoCount = 0;
		}


        if( isAttack == true ) {
            attackCount ++;
        }
        if( attackCount >= 50 ) {
            attack.gameObject.SetActive(false);
            attackCount = 0;
            isAttack = false;
        }

		if (hitBall >= 30 ) {
			time++;
			bigbang1.gameObject.SetActive(true);
			monoDie.SetActive (true);

			Destroy (bossHonki);
			OubeController.SetActive (false);
			PosithonController.SetActive (false);
		}

		if (time >= 20) {
			bigbang2.gameObject.SetActive(true);
		}

		if (time >= 50) {
			bigbang3.gameObject.SetActive(true);
		}
		if (time >= 80) {
			bigbang4.gameObject.SetActive(true);
		}

		if (time >= 120) {
			clearUI.SetActive ( true );

			//darkMist.gameObject.SetActive (false);
			winkClearVoice.SetActive (true);
		}

		if (time >= 900) {
			gameObject.SetActive(true);
			Application.LoadLevel ("bossResult_kin");
			hitBall = 0;
			CollisionPlayer.hitBall = 0;  
		
		}
	}

}
