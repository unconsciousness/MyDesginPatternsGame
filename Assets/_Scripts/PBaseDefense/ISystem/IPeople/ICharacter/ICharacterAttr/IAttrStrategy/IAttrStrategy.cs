using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//角色属性计算接口
public abstract class IAttrStrategy
{

    //初始的属性
    public abstract void InitAttr(ICharacterAttr CharacterAttr);

    //攻击加成
    //public int GetAtkPlusValue(int Rate, int AtkValue)
    //{
    //	int RandValue = UnityEngine.Random.Range(0, 100);
    //	if (Rate > RandValue)
    //		return AtkValue;
    //	return 0;
    //}
    public abstract int GetAtkPlusValue(ICharacterAttr CharacterAttr);



    //获取减少伤害值
    public abstract int GetDmgDescValue(ICharacterAttr CharacterAttr);
}
