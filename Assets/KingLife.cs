using UnityEngine;
using System.Collections;

public class KingLife : MonoBehaviour {

	public Renderer rend;

	void Start() {
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("LavaScrolling_2");
	}
	void Update() {
		float power = 0.5f;
		rend.material.SetFloat("_Emissionpower", power);
	}
	
}