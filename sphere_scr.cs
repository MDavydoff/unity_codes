using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_scr : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	float h;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		v=Input.GetAxis("Vertical");
		h=Input.GetAxis("Horizontal");
		//Vector3 force = new Vector3 (0, 0, v);
		rb.AddForce(tr.forward * v * 50f);
		Vector3 rotation = new Vector3 (0, h, 0);
		tr.Rotate (rotation);

	}
	void OnCollisionEnter(Collision arg) {
		if (arg.gameObject.tag == "prize"){
			Destroy (arg.gameObject);
		}
	}
}