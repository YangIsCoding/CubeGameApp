using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollsion : MonoBehaviour {

	public playerMovement movement;


	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.collider.tag == "obstacles"){
			Debug.Log ("we hit");
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame();
		}
	}
}
