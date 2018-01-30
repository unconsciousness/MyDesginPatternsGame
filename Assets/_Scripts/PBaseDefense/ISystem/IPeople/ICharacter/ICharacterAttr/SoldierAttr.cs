using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAttr : ICharacterAttr
{
    protected int m_SoldierLv = 0;//等级
    protected int m_AddMaxHP;//等级新增的HP值

    public SoldierAttr() { }

    public SoldierAttr(int MaxHP, float MoveSpeed, string AttrName)
    {
        m_MaxHP = MaxHP;
        m_MoveSpeed = MoveSpeed;
        m_NowHP = MaxHP;
        m_AttrName = AttrName;
    }

    //设置等级
    public void SetSoldierLv(int Lv)
    {
        m_SoldierLv = Lv;
    }

    //获取等级
    public int GetSoldierLv()
    {
        return m_SoldierLv;
    }

    //设置新增的最大生命力
    public void AddMaxHP(int AddMaxHP)
    {
        m_AddMaxHP = AddMaxHP;
    }

    //最大HP显示
    public override int GetMaxHP()
    {
        return base.GetMaxHP() + m_AddMaxHP;
    }
}
