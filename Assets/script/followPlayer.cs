using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {
	public Transform player; 
	public Vector3 offset;

	void Update () { 
		transform.position = player.position + offset;//小寫的transform 是此物件（目前為camera）的位置
	}
}
