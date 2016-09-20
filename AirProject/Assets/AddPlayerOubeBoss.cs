using UnityEngine;
using System.Collections;

namespace Vuforia {

	public class AddPlayerOubeBoss : MonoBehaviour {

		DefaultTrackableEventHandler DefaultTrackableEventHandler;

		//属性ＵＩ
		public GameObject typeFire;
		public GameObject typeWater;
		public GameObject typeThunder;
		public GameObject typeSoil;

		//属性オーブ
		public GameObject FireCharge;
		public GameObject FireNomal;
		public GameObject WaterCharge;
		public GameObject WaterNomal;
		public GameObject SoilCharge;
		public GameObject SoilNomal;
		public GameObject ThunderCharge;
		public GameObject ThunderNomal;

		public GameObject testtext;

		bool isFireShot = false;
		bool isWaterShot = false;
		bool isSoilShot = false;
		bool isThunderShot = false;

		public GameObject camera;
        public GameObject cameraParent;

		private GameObject PlayerOube;

		public Vector3 placePosition;
		Quaternion q = new Quaternion();

		public int isTracking = 0;
		public int isFireTracking = 0;
		public int isWaterTracking = 0;
		public int isSoilTracking = 0;
		public int isThunderTracking = 0;


		bool isExisting = false;
		public static bool isCompleting = false;
		public static int oubeShot = 0;
		float oubeSize = 0;

		public int spellSwitch = 0;
		int oldspellSwitch = 0;
		int testtime = 0;
		bool testSw = false;

		float waitTime = 0;

		public static bool initSwitch = false;

		// Use this for initialization
		void Start () {
			q = FireNomal.transform.rotation;
		}

		// Update is called once per frame
		void Update () {	
			isTracking = DefaultTrackableEventHandler.isTracking;
			isFireTracking = DefaultTrackableEventHandler.isFireTracking;
			isWaterTracking = DefaultTrackableEventHandler.isWaterTracking;
			isSoilTracking = DefaultTrackableEventHandler.isSoilTracking;
			isThunderTracking = DefaultTrackableEventHandler.isThunderTracking;

			// オーブ座標
			placePosition = camera.transform.position;
			placePosition.z = camera.transform.position.z + 1.5f;
			placePosition.y = camera.transform.position.y - 0.5f;

			//AR読み込み
			if (isTracking == 1) {
				//オーブが存在しているか
				if (isExisting) {
					isCompleting = true;
				} else {
					camera.transform.localRotation = Quaternion.Euler(0, 0, 0);
					if (isFireTracking == 1) {
						AddOubeFire ( );
					} else if (isWaterTracking == 1) {
						AddOubeWater( );
					} else if (isSoilTracking == 1) {
						AddOubeSoil( );
					} else if (isThunderTracking == 1) {
						AddOubeThunder( );
					} else {
						AddOubeNomal ();
					}
					isExisting = true;
				}
			} else if( isTracking == 0 ){

			}

			//発射準備
			if (isCompleting) {

				oldspellSwitch = spellSwitch;
				spellSwitch = ReadMsg.spellSwitch;
				if (oldspellSwitch != spellSwitch) {
					testSw = true;
					if (spellSwitch == 1) {
						oubeShot = 1;
					} else if (spellSwitch == 2) {
						oubeShot = 1;
					} else if (spellSwitch == 3) {
						oubeShot = 1;
					} else if (spellSwitch == 4) {
						oubeShot = 1;
					}
				}
			}

			if (oubeShot == 1) {
				waitTime += Time.deltaTime;

				typeWater.SetActive (false);
				typeFire.SetActive (false);
				typeSoil.SetActive (false);
				typeThunder.SetActive (false);
			}
			if (waitTime >= 8.0f ) {
				if (isFireShot) {
					Destroy (FireCharge, 0.0f);
					Destroy (FireNomal, 0.0f);
				}
				if (isWaterShot) {
					Destroy (WaterCharge, 0.0f);
					Destroy (WaterNomal, 0.0f);
				}
				if (isSoilShot) {
					Destroy (SoilCharge, 0.0f);
					Destroy (SoilNomal, 0.0f);
				}
				if (isThunderShot) {
					Destroy (ThunderCharge, 0.0f);
					Destroy (ThunderNomal, 0.0f);
				}
				Init ();
				initSwitch = true;
			}
		}

		public void AddOubeNomal( ) {
			FireCharge = (GameObject)Resources.Load ("Prefabs/FireCharge");
			FireNomal = (GameObject)Resources.Load ("Prefabs/FireOube");

			FireNomal = (GameObject) Instantiate(FireNomal,placePosition,q);
			FireNomal.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			FireNomal.transform.parent = camera.transform;
			FireNomal.name = "PlayerOubeNomal";

			FireCharge = (GameObject) Instantiate(FireCharge,placePosition,q);
			FireCharge.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			FireCharge.transform.parent = camera.transform;
			FireCharge.name = "PlayerChargeNomal";
		}

		public void AddOubeFire( ) {
			FireCharge = (GameObject)Resources.Load ("Prefabs/FireCharge");
			FireNomal = (GameObject)Resources.Load ("Prefabs/FireOube");

			FireNomal = (GameObject) Instantiate(FireNomal,placePosition,q);
			FireNomal.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			FireNomal.transform.parent = camera.transform;
			FireNomal.name = "PlayerOubeFire";

			FireCharge = (GameObject) Instantiate(FireCharge,placePosition,q);
			FireCharge.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			FireCharge.transform.parent = camera.transform;
			FireCharge.name = "PlayerChargeFire";

			typeFire.SetActive (true);
			isFireShot = true;
		}

		public void AddOubeWater( ) {
			WaterCharge = (GameObject)Resources.Load ("Prefabs/WaterCharge");
			WaterNomal = (GameObject)Resources.Load ("Prefabs/WaterNomal");

			WaterNomal = (GameObject) Instantiate(WaterNomal,placePosition,q);
			WaterNomal.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			WaterNomal.transform.parent = camera.transform;
			WaterNomal.name = "PlayerOubeWater";

			WaterCharge = (GameObject) Instantiate(WaterCharge,placePosition,q);
			WaterCharge.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			WaterCharge.transform.parent = camera.transform;
			WaterCharge.name = "PlayerChargeWater";

			typeWater.SetActive (true);
			isWaterShot = true;
		}

		public void AddOubeSoil( ) {
			SoilCharge = (GameObject)Resources.Load ("Prefabs/SoilCharge");
			SoilNomal = (GameObject)Resources.Load ("Prefabs/SoilNomal");

			SoilNomal = (GameObject) Instantiate(SoilNomal,placePosition,q);
			SoilNomal.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			SoilNomal.transform.parent = camera.transform;
			SoilNomal.name = "PlayerOubeSoil";

			SoilCharge = (GameObject) Instantiate(SoilCharge,placePosition,q);
			SoilCharge.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			SoilCharge.transform.parent = camera.transform;
			SoilCharge.name = "PlayerChargeSoil";

			typeSoil.SetActive (true);
			isSoilShot = true;
		}

		public void AddOubeThunder( ) {
			ThunderCharge = (GameObject)Resources.Load ("Prefabs/ThunderCharge");
			ThunderNomal = (GameObject)Resources.Load ("Prefabs/ThunderNomal");

			ThunderNomal = (GameObject) Instantiate(ThunderNomal,placePosition,q);
			ThunderNomal.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			ThunderNomal.transform.parent = camera.transform;
			ThunderNomal.name = "PlayerOubeThunder";

			ThunderCharge = (GameObject) Instantiate(ThunderCharge,placePosition,q);
			ThunderCharge.transform.localScale = new Vector3( 0.05f, 0.05f, 0.05f);
			ThunderCharge.transform.parent = camera.transform;
			ThunderCharge.name = "PlayerChargeThunder";

			typeThunder.SetActive (true);
			isThunderShot = true;
		}		

		public void Init( ) {
			oubeSize = 0;
			isExisting = false;
			isCompleting = false;
			oubeShot = 0;
			waitTime = 0;
		}
	}
}