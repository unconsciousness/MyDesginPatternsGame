using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAttrStrategy : IAttrStrategy
{
    public override void InitAttr(ICharacterAttr CharacterAttr)
    {
        //是否为士兵类
        SoldierAttr theSoldierAttr = CharacterAttr as SoldierAttr;
        if (theSoldierAttr == null)
        {
            return;
        }

        //最大生命力有等级加成
        int AddMaxHP = 0;
        int Lv = theSoldierAttr.GetSoldierLv();
        if (Lv > 0)
            AddMaxHP = (Lv - 1) * 2;

        //设置最高HP
        theSoldierAttr.AddMaxHP(AddMaxHP);
    }



    //攻击加成
    public override int GetAtkPlusValue(ICharacterAttr CharacterAttr)
    {
        return 0;
    }

    //获取减少伤害值
    public override int GetDmgDescValue(ICharacterAttr CharacterAttr)
    {
        //是否为士兵类
        SoldierAttr theSoldierAttr = CharacterAttr as SoldierAttr;
        if (theSoldierAttr == null)
        {
            return 0;
        }

        //返回减少伤害值
        return (theSoldierAttr.GetSoldierLv() - 1) * 2;
    }


}
