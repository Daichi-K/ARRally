using UnityEngine;
using System.Collections;

public class Boss_Anime : MonoBehaviour {

	float waitTime = 0;
	Animator _animator;

	bool one1 = true;
	bool one2 = true;
	bool one3 = true;
	bool one4 = true;

	// Use this for initialization
	void Start () {
		_animator = this.GetComponent<Animator>();

		one1 = true;
		one2 = true;
		one3 = true;
		one4 = true;

	}
	
	// Update is called once per frame
	void Update () {
		waitTime += 1;
		_animator.SetBool("attack", false );
		_animator.SetBool("TypeChange", false );

		if (waitTime == 340) {
			_animator.SetBool("attack", true );
		}

		if (waitTime == 360 ) {
			waitTime = 0;
		}

		if ( EffectScript.hitBall == 30 ) {
			_animator.SetBool("die", true );
		}

		if (!EffectScript.farstBossStyle1) {
			if (one1) {
				_animator.SetBool("TypeChange", true );
				one1 = false;
				Debug.Log ("入ったよ");
			}
		}
		if (!EffectScript.farstBossStyle2) {
			if (one2) {
				_animator.SetBool("TypeChange", true );
				one2 = false;
			}
		}
		if (!EffectScript.farstBossStyle3) {
			if (one3) {
				_animator.SetBool("TypeChange", true );
				one3 = false;
			}
		}
		if (!EffectScript.farstBossStyle4) {
			if (one4) {
				_animator.SetBool("TypeChange", true );
				one4 = false;
			}
		}
	}
}