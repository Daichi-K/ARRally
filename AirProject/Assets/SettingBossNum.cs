using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingBossNum : MonoBehaviour {

	public Text scoreText; //Text用変数
	public static int score = 10; //スコア計算用変数

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "" + score.ToString ();
	}
}
