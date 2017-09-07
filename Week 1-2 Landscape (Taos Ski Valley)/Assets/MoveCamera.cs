using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	//Declare a variable for speed
	public float moveSpeedBox;
	public float Spinbox; 


	// Use this for initialization
	void Start () {
		moveSpeedBox = 0.01f; 
		Spinbox = 30f; 

	}

	// Update is called once per frame
	void Update () {

		float move = Input.GetAxisRaw ("Vertical") * 2;
		float rotate = Input.GetAxisRaw ("Horizontal") * 5;

		Debug.Log (move);
		Debug.Log (rotate);

		transform.Translate(move, 0, 0);
		transform.Rotate (0, rotate, 0);
		transform.Translate (0, 0, move);

	}
}
