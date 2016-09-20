using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossNumLeght : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPush( ) {
		SettingBossNum.score -= 1;
	}
}
