using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SadState : CubeState {

	private Cube cube;

	public SadState(Cube theCube)
	{
		this.cube = theCube;
	}

	public void Init()
	{
		// do nothing
	}
	
	// Update is called once per frame
	public void Update () {
		// shrink in Y scale and expand in X and Z as if the cube is melting
		if(cube.IsOnGround)
			cube.transform.localScale = Vector3.Lerp(cube.transform.localScale, new Vector3(3, 1, 3), 0.015f);
	}
}
