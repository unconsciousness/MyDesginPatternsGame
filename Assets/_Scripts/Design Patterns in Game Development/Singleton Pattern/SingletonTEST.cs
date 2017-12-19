using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTEST : MonoBehaviour
{


	void Start()
	{
		UnitTest();
	}


	void UnitTest()
	{
		Singleton.Instance.Name = "Hello";
		Singleton.Instance.Name = "Boy";
		print(Singleton.Instance.Name);
		//Singleton S=new Singleton();
		//error CS0122
	}

}
