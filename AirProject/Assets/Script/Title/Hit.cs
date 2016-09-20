using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
	public int count = 0;

	public string nextSecneName;

	bool isSwitch = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isSwitch) {
			count++;
			if (count >= 120) {
				Application.LoadLevel (nextSecneName);
			}
		} else {
			count = 0;
		}
	}

	public void OnOver(){
		isSwitch = true;
	}

	public void ExitOver( ) {
		isSwitch = false;
	}
}
