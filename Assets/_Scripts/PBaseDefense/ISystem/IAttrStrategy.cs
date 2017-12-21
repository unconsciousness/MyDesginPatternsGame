using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAttrStrategy  {

	public abstract void InitAttr();

	public int GetAtkPlusValue(int Rate, int AtkValue)
	{
		int RandValue = UnityEngine.Random.Range(0, 100);
		if (Rate > RandValue)
			return AtkValue;
		return 0;
	}

	public abstract int GetDmgDescValue();
}
