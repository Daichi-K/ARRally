using UnityEngine;
using System.Collections;

public class TestAnime : MonoBehaviour {

	Animator _animator;
	int time = 0;

	void Start ()
	{
		_animator = this.GetComponent<Animator>();
	}

	public void changeAnimation(){
		//ele1->ele2に切り替える
		_animator.SetBool("isClick", true );
	}
	
	// Update is called once per frame
	void Update () {
		time++;
		if (time > 120) {
			changeAnimation ();
		}
	}
}
