using UnityEngine;
using System.Collections;

public class goTitle : MonoBehaviour {

	float waitTime = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		waitTime += Time.deltaTime;
		if (waitTime >= 5.0f) {
			Application.LoadLevel ("Title");
		}
	}
}
