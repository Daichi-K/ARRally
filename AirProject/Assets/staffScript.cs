using UnityEngine;
using System.Collections;

public class staffScript : MonoBehaviour {

	public GameObject[] staffCanvas;

	public float changeScreen = 8.0f;
	public int screenCount = 0;
	public float timer;
	float size = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		staffCanvas[screenCount].transform.localScale = new Vector3( size, size, 0.05f);

		if (size <= 1.9f) {
			size += 0.04f;
		}
	
		if (timer >= changeScreen) {
			staffCanvas [screenCount].SetActive ( false );
			size = 0;
			screenCount++;
			staffCanvas [screenCount].SetActive ( true );
			timer = 0;
		}
	}
}
