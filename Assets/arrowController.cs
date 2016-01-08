using UnityEngine;
using System.Collections;

public class arrowController : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	public void OnTriggerEnter(Collider collider) {

		Destroy (this.gameObject, 1);
	}
}
