using UnityEngine;
using System.Collections;

public class BossCamera : MonoBehaviour {

	public GameObject camera;
	public static int oubeSwitch = 0;
	public static int arOubeSwitch = 0;
	public int oubeStopTime = 0;

	//ジャイロ
	private GUIStyle labelStyle;
	public static Quaternion ini_gyro;



	// Use this for initialization
	void Start () {
		//ジャイロ
		this.labelStyle = new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 22;
		this.labelStyle.normal.textColor = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		//ジャイロ
		Input.gyro.enabled = true;
		if (Input.gyro.enabled) {
			ini_gyro = Input.gyro.attitude;
			this.transform.localRotation = Quaternion.Euler (90, 0, 0) * (new Quaternion (-ini_gyro.x, -ini_gyro.y, ini_gyro.z, ini_gyro.w)); 
		}
	}
}
