using UnityEngine;
using System.Collections;

public class SoapCamera : MonoBehaviour {

	public GameObject yogore0;
	public GameObject yogore1;
	public GameObject yogore2;
	public GameObject yogore3;
	public GameObject yogore4;
	public GameObject yogore5;
	public GameObject yogore6;
	public GameObject yogore7;
	public GameObject yogore8;
	public GameObject yogore9;
	public GameObject yogore10;
	public GameObject yogore11;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();


			if (Physics.Raycast (ray, out hit)) {
				GameObject obj = hit.collider.gameObject;

				if (obj.name == "yogore0") {
					yogore0.SetActive (false);
				}
				if (obj.name == "yogore1") {
					yogore1.SetActive (false);
				}
				if (obj.name == "yogore2") {
					yogore2.SetActive (false);
				}
				if (obj.name == "yogore3") {
					yogore3.SetActive (false);
				}
				if (obj.name == "yogore4") {
					yogore4.SetActive (false);
				}
				if (obj.name == "yogore5") {
					yogore5.SetActive (false);
				}
				if (obj.name == "yogore6") {
					yogore6.SetActive (false);
				}
				if (obj.name == "yogore7") {
					yogore7.SetActive (false);
				}
				if (obj.name == "yogore8") {
					yogore8.SetActive (false);
				}
				if (obj.name == "yogore9") {
					yogore9.SetActive (false);
				}
				if (obj.name == "yogore10") {
					yogore10.SetActive (false);
				}
				if (obj.name == "yogore11") {
					yogore11.SetActive (false);
				}
			}
		}
	}
}
