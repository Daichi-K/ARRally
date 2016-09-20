using UnityEngine;
using System.Collections;

public class TouchHandler : MonoBehaviour {

	public static int hitCount = 0;
	Animator _animator;
	int time = 0;

	void Start ()
	{
		_animator = this.GetComponent<Animator>();
	}

	void Update () {
		time++;

		if (time >= 1180) {
			TouchHandler.hitCount = 0;
		}

		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				_animator = obj.GetComponent<Animator>();
				_animator.SetBool("isClick", true );
				hitCount++;
			}
		}
	}
}