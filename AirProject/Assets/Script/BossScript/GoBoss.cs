using UnityEngine;
using System.Collections;

public class GoBoss : MonoBehaviour {

	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag ("Finish")) {
			Application.LoadLevel ("boss");
		}
	}
}