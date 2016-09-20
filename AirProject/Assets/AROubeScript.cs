using UnityEngine;
using System.Collections;

public class AROubeScript : MonoBehaviour {

	public GameObject arOube;
	public int oubeSwitch = 0;
	public int arOubeSwitch = 0;
	public int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		arOubeSwitch = BossCamera.arOubeSwitch;

		if (arOubeSwitch == 0) {
			arOube.SetActive (true);
		}
		if (arOubeSwitch == 1) {
			arOube.SetActive (false);
		} 

		if (count >= 60) {
			arOubeSwitch = 0;
			count = 0;
		}
	}
}
