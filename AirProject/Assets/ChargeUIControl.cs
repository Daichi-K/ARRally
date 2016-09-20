using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Vuforia {
	public class ChargeUIControl : MonoBehaviour {
	
		public Slider ChargeGage;
		public GameObject Gage;
		public GameObject standBy;

		float num = 0;
		float timer  = 0;

		public bool isTracking = false;
		public bool isMax = false;
	
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			//トラッキングされました
			if (DefaultTrackableEventHandler.isTracking == 1) {
				isTracking = true;
			}

			if (isTracking) {
				Gage.SetActive (true);
				num += 0.02f;
				ChargeGage.value = num;
			}

			//ゲージがマックスになった
			if( num >= ChargeGage.maxValue ) {
				isMax = true;
				standBy.SetActive (true);
				timer += Time.deltaTime;
			}

			//２秒後
			if(timer >= 2.05f ) {
				standBy.SetActive (false);
				Gage.SetActive (false);
			}

			//球が打たれたら初期化
			if( AddPlayerOubeBoss.initSwitch ) {
				num = 0;
				timer  = 0;
				isTracking = false;
				isMax = false;
				AddPlayerOubeBoss.initSwitch = false;
			}
		}
	}
}
