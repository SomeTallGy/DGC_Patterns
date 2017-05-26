using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NormalState : CubeState {

	private Cube cube;

	public NormalState(Cube theCube)
	{
		this.cube = theCube;
	}

	public void Init()
	{
		// 1. return to normal scale at normal speed
		cube.transform.DOScale(new Vector3(2, 2, 2), 0.5f);
	}
	
	// Update is called once per frame
	public void Update () {
		// do nothing
	}
}
