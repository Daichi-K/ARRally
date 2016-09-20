using UnityEngine;
using System.Collections;

public class EnemyShotTutorial : MonoBehaviour {

	public GameObject enemyballtutorial;
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
		waitTime += 1;

		placePosition = this.transform.position;

		if (waitTime == 200) {	//2byou
			monoAttaclVoice.SetActive (true);
		}
		if (waitTime == 300) {
			enemyballtutorial = (GameObject) Instantiate(enemyballtutorial,placePosition,q);
		}
		if (waitTime == 80) {
			monoAttaclVoice.SetActive (false);
		}
	}
}
