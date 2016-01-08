using UnityEngine;
using System.Collections;

public class PotionController : MonoBehaviour {

	private float amplitude;          //Set in Inspector 
	private float speed;                  //Set in Inspector 
	private float tempVal;
	private Vector3 tempPos;

	// Use this for initialization
	void Start () {
		amplitude = 0.15f;
		speed = 0.7f;
		tempVal = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		tempPos.y = tempVal + amplitude * Mathf.Sin (speed * Time.time);
		tempPos.x = transform.position.x;
		tempPos.z = transform.position.z;
	
		transform.position = tempPos;
	}
}


