using UnityEngine;
using System.Collections;

public class WinkAnime : MonoBehaviour {

	public Texture nomalTex;
	public Texture sadTex;
	public Texture smailTex;
	public Texture odorokiTex;

	public float timer = 0;

	// Use this for initialization
	void Start () {
		this.GetComponent<Renderer> ().material.mainTexture = nomalTex;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= 2) {
			this.GetComponent<Renderer> ().material.mainTexture = smailTex;
		}
		if (timer >= 16) {
			this.GetComponent<Renderer> ().material.mainTexture = nomalTex;
		}
		if (timer >= 52) {
			this.GetComponent<Renderer> ().material.mainTexture = odorokiTex;
		}
	}
}
