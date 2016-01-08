using UnityEngine;
using System.Collections;

public class FireBow : MonoBehaviour {

	public Rigidbody arrowPrefab;

	private Vector3 distance;
	private Vector3 minDistance = new Vector3(5.5f, 0, 5.5f);
	private Vector3 defaultPos;
	private Vector3 heroPos;

	private float speed = 90;
	private float step;
	

	Animator animator;

	Transform heroT;
	Transform arrowT;

	GameObject hero;
	GameObject arrow;
	
	Rigidbody arrowRb;
	Rigidbody arrowCloneRb;

	private bool firingNow;


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();

		hero = GameObject.Find ("ThirdPersonController");
		arrow = transform.Find ("Arrow").gameObject;
		
		heroT = hero.transform;
		arrowT = arrow.transform;
	
		animator.SetBool ("HasFinished", true);

	}
	
	// Update is called once per frame
	void Update () {

		distance = transform.position - heroT.position;
			
		if (((Mathf.Abs (distance.x) < minDistance.x) && (Mathf.Abs (distance.z) < minDistance.z)) && animator.GetBool("HasFinished")) {
			animator.SetBool ("IsFiring", true);
		}		
	}


	public void FireArrow()
	{

		Rigidbody arrowClone = (Rigidbody) Instantiate(arrowPrefab);

		arrowClone.transform.LookAt(heroT);

		arrowClone.AddForce(arrowT.forward * 500);

		Destroy(arrowClone, 1);

	}



	public void FiringFalse() {
		animator.SetBool ("HasFinished", true);
		animator.SetBool ("IsFiring", false);
	}
	public void FiringTrue() {
		animator.SetBool ("HasFinished", false);
	}


	
}
