using UnityEngine;
using System.Collections;

namespace Vuforia {
		
	public class AddPlayerOube : MonoBehaviour {
	
		DefaultTrackableEventHandler DefaultTrackableEventHandler;

		public GameObject oubePrefab;
		public GameObject camera;
		public GameObject Tutorial2;
		public GameObject Tutorial3;

		private GameObject PlayerOube;

		public Vector3 placePosition;
		Quaternion q = new Quaternion();
	
		public int isTracking = 0;
		bool isExisting = false;
		bool isCompleting = false;
		public static int oubeShot = 0;
		float oubeSize = 0;

		bool Tutorial3Switch = false;

		float waitTime = 0;
	
		// Use this for initialization
		void Start () {
			q = oubePrefab.transform.rotation;
		}
		
		// Update is called once per frame
		void Update () {	
			isTracking = DefaultTrackableEventHandler.isTracking;

			// オーブ座標
			placePosition = camera.transform.position;
			placePosition.z = camera.transform.position.z + 1f;
			placePosition.y = camera.transform.position.y - 0.3f;

			//AR読み込み
			if (isTracking == 1) {
				//オーブが存在しているか
				if (isExisting) {
					isCompleting = true;
					if (!Tutorial3Switch) {
						Tutorial3.SetActive (true);
						Tutorial3Switch = true;
					}
				} else {
					Tutorial2.SetActive ( true );
					camera.transform.localRotation = Quaternion.Euler(0, 0, 0);
					AddOube ();
					isExisting = true;
				}
			} else if( isTracking == 0 ){
				//発射準備できてるか
				if (isCompleting) {
					oubeShot = 1;
				} else {
				
				}
			}
			if (oubeShot == 1) {
				waitTime += Time.deltaTime;
			}
			if (waitTime >= 2.5f ) {
				Init ();
			} 
		}

		public void AddOube( ) {
			oubePrefab = (GameObject) Instantiate(oubePrefab,placePosition,q);
			oubePrefab.transform.localScale = new Vector3( oubeSize, oubeSize, oubeSize );
			oubePrefab.transform.parent = camera.transform;
			oubePrefab.name = "PlayerOube";
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