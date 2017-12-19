using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTEST : MonoBehaviour {
	//int i = 0;
	
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(3);
		UnitTest();
		//Debug.Log(1);
		//yield return new WaitUntil(() => i > 800);
		//Debug.Log(2);
	}
	
	// Update is called once per frame
	void Update () {
	//	i++;
	}

	void UnitTest()
	{
		Context C = new Context();
		C.SetState(new ConcreteStateA(C));
		C.Request(5);
		C.Request(15);
		C.Request(25);
		C.Request(35);
	}
}
