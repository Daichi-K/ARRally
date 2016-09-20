using UnityEngine;
using System.Collections;

public class tcaBotton : MonoBehaviour {

	public GameObject tcaObj;

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

	public int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPush() {

		tcaObj.transform.Rotate (new Vector3 (0f, -180f, 0f));

		/*if (count == 1) {
			tcaObj.transform.rotation = new Quaternion (0, 200, 0, 0);
			count = 0;
		}else if (count == 0) {
			tcaObj.transform.rotation = new Quaternion (0, 20, 0, 0);
			count = 1;
		}*/
	}
}
