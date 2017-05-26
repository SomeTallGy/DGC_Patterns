using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// ------- inspector fields -------
	public Collider groundCollider;

	// --------- private fields -------
	private CubeState theState;

	// --------- properties -----------
	public CubeState State{
		get { return theState; } 
		set { 
			theState = value;
			theState.Init();	// call state's init function
		}
	}

	public bool IsOnGround{ get; private set;}

	// Update is called once per frame
	void Update () {
		State.Update();	// call state's update function
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.collider == groundCollider)
			IsOnGround = true;
	}

	void OnCollisionExit(Collision col)
	{
		if(col.collider == groundCollider)
			IsOnGround = false;
	}
}
