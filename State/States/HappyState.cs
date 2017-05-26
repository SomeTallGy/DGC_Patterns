using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HappyState : CubeState {

	private Cube cube;

	public HappyState(Cube theCube)
	{
		this.cube = theCube;
	}

	public void Init()
	{
		// 1. return to normal scale at fast speed
		cube.transform.DOScale(new Vector3(2, 2, 2), 0.2f);
	}
	
	// Update is called once per frame
	public void Update () {
		// hop the cube and jump around
		if(cube.IsOnGround)
		{
			cube.GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.Impulse);
			cube.GetComponent<Rigidbody>().AddTorque(Vector3.up, ForceMode.Impulse);
		}
			
	}
}
