using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttr : ICharacterAttr
{

    protected int m_CritRate = 0;//爆率

    public EnemyAttr() { }

    public EnemyAttr(int MaxHP, float MoveSpeed, int CritRate, string AttrName)
    {
        m_MaxHP = MaxHP;
        m_NowHP = MaxHP;
        m_MoveSpeed = MoveSpeed;
        m_CritRate = CritRate;
        m_AttrName = AttrName;
    }

    //暴击率
    public int GetCritRate()
    {
        return m_CritRate;
    }

    //减少暴击率
    public void CutdownCritRate()
    {
        m_CritRate -= m_CritRate / 2;
    }
}
