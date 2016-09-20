using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
	
	public Text scoreText; //Text用変数
	public static int score = 0; //スコア計算用変数

	void Update (){

		score = GameSelect.playerLevel;

		scoreText.text = "" + score.ToString ();
	}
}