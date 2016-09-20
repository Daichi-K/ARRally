using UnityEngine;
using System.Collections;

namespace Vuforia {
	public class jyumonScript : MonoBehaviour {
	
		public GameObject fireJyumon;
		public GameObject waterJyumon;
		public GameObject soilJyumon;
		public GameObject Thunderyumon;
				
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if (DefaultTrackableEventHandler.isFireTracking == 1) {
				fireJyumon.SetActive (true);

				waterJyumon.SetActive (false);
				soilJyumon.SetActive (false);
				Thunderyumon.SetActive (false);
			} else if (DefaultTrackableEventHandler.isWaterTracking == 1) {
				waterJyumon.SetActive (true);

				fireJyumon.SetActive (false);
				soilJyumon.SetActive (false);
				Thunderyumon.SetActive (false);
			} else if (DefaultTrackableEventHandler.isSoilTracking == 1) {
				soilJyumon.SetActive (true);

				fireJyumon.SetActive (false);
				waterJyumon.SetActive (false);
				Thunderyumon.SetActive (false);
			} else if (DefaultTrackableEventHandler.isThunderTracking == 1) {
				Thunderyumon.SetActive (true);

				fireJyumon.SetActive (false);
				waterJyumon.SetActive (false);
				soilJyumon.SetActive (false);
			} else {
				fireJyumon.SetActive (false);
				waterJyumon.SetActive (false);
				soilJyumon.SetActive (false);
				Thunderyumon.SetActive (false);
			}
		}
	}
}