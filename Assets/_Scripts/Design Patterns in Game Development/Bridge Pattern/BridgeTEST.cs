using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cube cube = new Cube();
		cube.SetRenderEngine(new DirectX());
		cube.Draw();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
