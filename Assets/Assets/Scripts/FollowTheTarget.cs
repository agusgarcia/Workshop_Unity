using UnityEngine;
using System.Collections;

public class FollowTheTarget : MonoBehaviour {
	
	Transform hero;

	// Use this for initialization
	void Start () {
		hero = GameObject.Find ("ThirdPersonController").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (hero);
	}
}
