using UnityEngine;
using System.Collections;

public class FollowTheCharacter : MonoBehaviour {

	public Transform hero;

	private Vector3 offset;

	void Start() {
	//	hero = GameObject.Find ("ThirdPersonController").transform;
		offset = transform.position - hero.transform.position;

	}

	void LateUpdate() {
		transform.position = hero.transform.position + offset;	

	}

}