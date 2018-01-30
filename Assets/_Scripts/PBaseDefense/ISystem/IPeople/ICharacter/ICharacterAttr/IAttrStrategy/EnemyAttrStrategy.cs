using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttrStrategy : IAttrStrategy
{

    //初始的属性
    public override void InitAttr(ICharacterAttr CharacterAttr)
    {
        //不用计算
    }


    //攻击加成
    public override int GetAtkPlusValue(ICharacterAttr CharacterAttr)
    {
        //是否为敌方属性
        EnemyAttr theEnemyAttr = CharacterAttr as EnemyAttr;
        if (theEnemyAttr == null)
            return 0;

        //按爆率返回攻击加成值
        int RandValue = UnityEngine.Random.Range(0, 100);
        if (theEnemyAttr.GetCritRate() >= RandValue)
        {
            theEnemyAttr.CutdownCritRate();//减少暴击概率
            return theEnemyAttr.GetMaxHP() * 5;//血量的5倍值
        }
        return 0;
    }

    public override int GetDmgDescValue(ICharacterAttr CharacterAttr)
    {
        return 0; //没有减少伤害值
    }


}
