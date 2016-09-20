using UnityEngine;
using System.Collections;

public class goResult : MonoBehaviour {

	public string nextScene;

	int count = 0;
	public int maxCount = 1200;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count++;

		if (count >= maxCount ) {
			Application.LoadLevel (nextScene);
		}
	}
}
