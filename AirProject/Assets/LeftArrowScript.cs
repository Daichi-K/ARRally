using UnityEngine;
using System.Collections;

public class LeftArrowScript : MonoBehaviour {

	public GameObject LeftArrowUI;

	bool onStay = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		LeftArrowUI.SetActive ( onStay );

	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Boss")) {
			onStay = true;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.CompareTag ("Boss")) {
			onStay = false;
		}
	}
}
