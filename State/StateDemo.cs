using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateDemo : MonoBehaviour
{

    // --------- inspector fields ------------
    public Cube theCube;
    public Text stateInfo;

	// --------- private fields --------------
	private CubeState normalState;
	private CubeState happyState;
	private CubeState sadState;

	void Start()
	{
		// 1. Initialize states
		normalState = new NormalState(theCube);
		happyState = new HappyState(theCube);
		sadState = new SadState(theCube);

		// 2. Default State
		theCube.State = normalState;
		stateInfo.text = "Cube is in "+theCube.State.GetType().Name;
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Normal"))
        {
            theCube.State = normalState;
			stateInfo.text = "Cube is in "+theCube.State.GetType().Name;
        }
        if (GUI.Button(new Rect(170, 10, 150, 100), "Sad"))
        {
            theCube.State = sadState;
			stateInfo.text = "Cube is in "+theCube.State.GetType().Name;
        }
        if (GUI.Button(new Rect(330, 10, 150, 100), "Happy"))
        {
            theCube.State = happyState;
			stateInfo.text = "Cube is in "+theCube.State.GetType().Name;
        }
    }

}
