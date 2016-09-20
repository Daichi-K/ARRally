using UnityEngine;
using System.Collections;

public class BreakWall : MonoBehaviour {
	bool breakSwitch = false;

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Player")) {
			breakSwitch = true;	
		}	
	}

	void Update () {
		if (breakSwitch == true ) {
			transform.Translate (0, 0, 1);
		}
	}

}
