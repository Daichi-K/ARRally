using UnityEngine;
using System.Collections;

namespace Vuforia {
public class TutorialController : MonoBehaviour {

		public float timer = 0;

		// Update is called once per frame
		void Update () {
			timer+= Time.deltaTime;

			if (timer >= 56) {
				Application.LoadLevel ("boss");
			}
		}
	}
}