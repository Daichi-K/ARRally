using UnityEngine;
using System.Collections;

public class BossAnimeTutorial : MonoBehaviour {

	float waitTime = 0;
	Animator _animator;

	// Use this for initialization
	void Start () {
		_animator = this.GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {
		waitTime += 1;
		_animator.SetBool("attack", false );

		if (waitTime == 240) {
			_animator.SetBool("attack", true );
		}
	}
}
