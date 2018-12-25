using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xaiya_PlayerAnimator : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)) {
			animator.SetBool("Up", true);
			animator.SetBool("Down", false);
			animator.SetBool("Left", false);
			animator.SetBool("Right", false);
		}
		if(Input.GetKey(KeyCode.S)) {
			animator.SetBool("Up", false);
			animator.SetBool("Down", true);
			animator.SetBool("Left", false);
			animator.SetBool("Right", false);
		}
		if(Input.GetKey(KeyCode.D)) {
			animator.SetBool("Up", false);
			animator.SetBool("Down", false);
			animator.SetBool("Left", false);
			animator.SetBool("Right", true);
		}
		if(Input.GetKey(KeyCode.A)) {
			animator.SetBool("Up", false);
			animator.SetBool("Down", false);
			animator.SetBool("Left", true);
			animator.SetBool("Right", false);
		}


		if(Input.GetKey(KeyCode.W)) {
			animator.SetBool("Walk Up", true);
		} else {
			animator.SetBool("Walk Up", false);
		}
		if(Input.GetKey(KeyCode.S)) {
			animator.SetBool("Walk Down", true);
		} else {
			animator.SetBool("Walk Down", false);
		}
		if(Input.GetKey(KeyCode.D)) {
			animator.SetBool("Walk Right", true);
		} else {
			animator.SetBool("Walk Right", false);
		}
		if(Input.GetKey(KeyCode.A)) {
			animator.SetBool("Walk Left", true);
		} else {
			animator.SetBool("Walk Left", false);
		}
	}
}
