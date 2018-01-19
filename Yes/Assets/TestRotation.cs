using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour {

	public GameObject target;
	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (Input.GetAxisRaw ("Horizontal"),0, Input.GetAxisRaw ("Vertical"));
		transform.position += (move * speed);
	}
}
