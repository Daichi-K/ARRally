using UnityEngine;
using System.Collections;


namespace Vuforia {
	public class StartEvent : MonoBehaviour {
	
		public GameObject warrningUI;
		public GameObject Boss;
		public GameObject BossStartEve;
		public GameObject BossTutorial;
	
		public GameObject winkStartVois;
		public GameObject winkMakerVois;
		public GameObject winkOubeVois;
		public GameObject winkYokeru;
		public GameObject winkYoketa;
		public GameObject winkBossType;
		public GameObject winkTyprAttack;

		public GameObject arrowDwon;

		public Texture nomalTex;
		public Texture sadTex;
		public Texture smailTex;
		public Texture odorokiTex;

		public GameObject wink;

		public static bool isStart = false;

		bool makerSwitch = true;
		bool OubeSwitch = true;
		int OubeCount = 0;
	
		int gameTime = 0;

		bool yokeru = false;
		int yokeruCount = 0;
	
		// Use this for initialization
		void Start () {
			makerSwitch = true;
			OubeSwitch = true;
			yokeru = false;
			yokeruCount = 0;
			OubeCount = 0;

			wink.GetComponent<Renderer> ().material.mainTexture = odorokiTex;
		}
		
		// Update is called once per frame
		void Update () {
	
			gameTime++;
	
			if (gameTime >= 180) {
				warrningUI.SetActive ( false );
			}
			if (gameTime >= 420) {
				BossStartEve.SetActive ( false );
				winkStartVois.SetActive ( true );
				wink.GetComponent<Renderer> ().material.mainTexture = sadTex;

			}
			if (gameTime >= 1440) {
				if (makerSwitch) {
					if (DefaultTrackableEventHandler.isTracking == 1) {
						winkMakerVois.SetActive ( true );
						makerSwitch = false;
					}
				}
			}
			if (gameTime >= 2580) {
				if (OubeSwitch) {
					if (AddPlayerOubeBoss.oubeShot == 1) {
						winkOubeVois.SetActive ( true );
						OubeSwitch = false;
						wink.GetComponent<Renderer> ().material.mainTexture = smailTex;
					}
				}
			}
			if (!OubeSwitch) {
				OubeCount++;
			}
			if (OubeCount >= 360) {
				BossTutorial.SetActive (true);
			}
			if ( !Oubetutorial.isMoving ) {
				winkYokeru.SetActive( true );
				arrowDwon.SetActive(true);
				yokeru = true;
				wink.GetComponent<Renderer> ().material.mainTexture = odorokiTex;
			}
			if (yokeru) {
				yokeruCount++;
			}
			if (yokeruCount >= 360) {
				winkYoketa.SetActive ( true );
				arrowDwon.SetActive(false);
				wink.GetComponent<Renderer> ().material.mainTexture = smailTex;
			}
			if (yokeruCount >= 1500) {
				BossTutorial.SetActive (false);
			}
			if (yokeruCount >= 2160) {
				Boss.SetActive (true);
				isStart = true;
			}

			if (!EffectScript.farstBossStyle1) {
				winkBossType.SetActive(true);
			}
			if (EffectScript.tutorialWater) {
				winkBossType.SetActive(false);
				winkTyprAttack.SetActive (true);
			}
		}
	}
}