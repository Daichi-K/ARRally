using UnityEngine;
using UnityEngine.Networking;

public class Sphere : NetworkBehaviour {

	[SerializeField]
	private float _speed;

	void Update() {
		Move();    
	}

	void Move() {
		if( !this.isLocalPlayer ) { return; }

		float x = Input.GetAxis( "Horizontal" ) * this._speed;
		float y = Input.GetAxis( "Vertical" ) * this._speed;
		this.transform.Translate( x, y, 0 );
	}
}
