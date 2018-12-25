using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isadora_PlayerController : MonoBehaviour {

	public float speed = 0.1f;

	Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player_Isadora").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 movement = Vector3.zero;

		if(Input.GetKey(KeyCode.U)) {
			movement = Vector3.up * speed;
		}
		if(Input.GetKey(KeyCode.J)) {
			movement = -Vector3.up * speed;
		}
		if(Input.GetKey(KeyCode.K)) {
			movement = Vector3.right * speed;
		}
		if(Input.GetKey(KeyCode.H)) {
			movement = -Vector3.right * speed;
		}

		player.Translate(movement);
	}
}
