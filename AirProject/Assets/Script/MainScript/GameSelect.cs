using UnityEngine;
using System.Collections;

public class GameSelect : MonoBehaviour {

	public static int gameScore = 0;

	public static int playerLevel = 1;

	public GameObject secret0;
	public GameObject secret1;
	public GameObject secret2;
	public GameObject secret3;
	public GameObject secret4;
	public GameObject secret5;
	public GameObject secret6;
	public GameObject secret7;

	public GameObject ghost0;
	public GameObject ghost1;
	public GameObject ghost2;
	public GameObject ghost3;
	public GameObject ghost4;
	public GameObject ghost5;
	public GameObject ghost6;
	public GameObject ghost7;

	public static bool switch0 = false;
	public static bool switch1 = false;
	public static bool switch2 = false;
	public static bool switch3 = false;
	public static bool switch4 = false;
	public static bool switch5 = false;
	public static bool switch6 = false;
	public static bool switch7 = false;

	public static bool DestrySwitch0 = false;
	public static bool DestrySwitch1 = false;
	public static bool DestrySwitch2 = false;
	public static bool DestrySwitch3 = false;
	public static bool DestrySwitch4 = false;
	public static bool DestrySwitch5 = false;
	public static bool DestrySwitch6 = false;
	public static bool DestrySwitch7 = false;


	int time = 0;

	void Start ( ) {
		playerLevel = 1;
	}


	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();


			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;

				//ボス戦
				if (obj.name == "boss") {
					Application.LoadLevel ("bossTitle");
				}

				//隠れマーカー
				if ( obj.name == "secret0" ) {
					if (switch0 == false) {
						playerLevel += 1;
					}
					secret0.SetActive(true);
					ghost0.SetActive ( false );
					switch0 = true;
					secret0.transform.LookAt(this.transform);

				}
				if ( obj.name == "secret1" ) {
					if (switch1 == false) {
						playerLevel += 1;
					}
					secret1.SetActive(true);
					ghost1.SetActive ( false );
					switch1 = true;
					secret1.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret2" ) {
					if (switch2 == false) {
						playerLevel += 1;
					}
					secret2.SetActive(true);
					ghost2.SetActive ( false );
					switch2 = true;
					secret2.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret3" ) {
					if (switch3 == false) {
						playerLevel += 1;
					}
					secret3.SetActive(true);
					ghost3.SetActive ( false );
					switch3 = true;
					secret3.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret4" ) {
					if (switch4 == false) {
						playerLevel += 1;
					}
					secret4.SetActive(true);
					ghost4.SetActive ( false );
					switch4 = true;
					secret4.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret5" ) {
					if (switch5 == false) {
						playerLevel += 1;
					}
					secret5.SetActive(true);
					ghost5.SetActive ( false );
					switch5 = true;
					secret5.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret6" ) {
					if (switch6 == false) {
						playerLevel += 1;
					}
					secret6.SetActive(true);
					ghost6.SetActive ( false );
					switch6 = true;
					secret6.transform.LookAt(this.transform);
				}
				if ( obj.name == "secret7" ) {
					if (switch6 == false) {
						playerLevel += 7;
					}
					secret7.SetActive(true);
					ghost7.SetActive ( false );
					switch7 = true;
					secret7.transform.LookAt(this.transform);
				}

			}
		}

		//隠れマーカークリック処理
		if (switch0) {
			time++;
			secret0.transform.Translate (0, 0, 0.05f);
		}
		if (switch1) {
			time++;
			secret1.transform.Translate (0, 0, 0.05f);
		}
		if (switch2) {
			time++;
			secret2.transform.Translate (0, 0, 0.05f);
		}
		if (switch3) {
			time++;
			secret3.transform.Translate (0, 0, 0.05f);
		}
		if (switch4) {
			time++;
			secret4.transform.Translate (0, 0, 0.05f);
		}
		if (switch5) {
			time++;
			secret5.transform.Translate (0, 0, 0.05f);
		}
		if (switch6) {
			time++;
			secret6.transform.Translate (0, 0, 0.05f);
		}
		if (switch7) {
			time++;
			secret7.transform.Translate (0, 0, 0.05f);
		}

	}
}
