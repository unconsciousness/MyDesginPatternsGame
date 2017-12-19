using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton  {

	public string Name { get; set; }





	private static Singleton uniqueInstance=null;



	public static Singleton Instance
	{
		get{
			if (uniqueInstance == null)
			{
				Debug.Log("Now , i new the Singleton");
				uniqueInstance = new Singleton();
			}
			return uniqueInstance;
		}
		
	}
	private Singleton() { }


	public void SingletonOperation() { }

	public void GetSingletonData() { }
}
