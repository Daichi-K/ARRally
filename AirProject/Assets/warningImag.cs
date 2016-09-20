using UnityEngine;
using System.Collections;

public class warningImag : MonoBehaviour {

    public GameObject obe;
	public GameObject BossPositionCont;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0)) {
          this.gameObject.SetActive( false );
            obe.gameObject.SetActive( true );
			BossPositionCont.SetActive (true);
        }
	
	}
}
