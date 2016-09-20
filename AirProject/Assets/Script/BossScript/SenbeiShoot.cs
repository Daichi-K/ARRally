using UnityEngine;
using System.Collections;

namespace Vuforia {

	public class SenbeiShoot : MonoBehaviour {
		int senbeiSpeed = 2;
		float waitTime = 0;
		public int oubeSwitch = 0;

		void Start () {

		}

		void Update () {

			oubeSwitch = AddPlayerOube.oubeShot;

			if ( oubeSwitch == 1 ) {
				transform.Translate (0, 0, senbeiSpeed);
				waitTime += Time.deltaTime;
			}

			if (waitTime >= 2.0f) {
				//Destroy(gameObject,.1f);
			}
		}
	}
}