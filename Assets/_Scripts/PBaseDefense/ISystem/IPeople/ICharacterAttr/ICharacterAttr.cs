using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterAttr
{

    protected int m_MaxHP = 0;
    protected int m_NowHP = 0;
    protected float m_MoveSpeed = 1.0f;
    protected string m_AttrName = "";//属性名字

    protected IAttrStrategy m_AttrStrategy = null;//属性的计算策略

    //设置属性的计算策略
    public void SetAttrStrategy(IAttrStrategy theAttrStrategy)
    {
        m_AttrStrategy = theAttrStrategy;
    }

    //获取属性的计算策略
    public IAttrStrategy GetAttrStrategy()
    {
        return m_AttrStrategy;
    }

    //初始化角色属性
    public virtual void InitAttr()
    {
        m_AttrStrategy.InitAttr(this);
        //FullNowHP();
    }

    //攻击加成
    public int GetAtkPlusValue()
    {
        return m_AttrStrategy.GetAtkPlusValue(this);
    }

    //获取被武器攻击后的伤害值
    public void CalDmgValue(ICharacter Attacker)
    {
        //获取武器攻击力
        int AtkValue = Attacker.GetAtkValue();

        //减少伤害值
        AtkValue -= m_AttrStrategy.GetDmgDescValue(this);

        //扣去伤害值
        m_NowHP -= AtkValue;

    }

    public  string GetAttrName()
    {
        return m_AttrName;
    }



    //当前HP
    public int GetNowHP()
    {
        return m_NowHP;
    }


    //最大HP
    public virtual int GetMaxHP()
    {
        return m_MaxHP;
    }

    //移动速度累计
    public virtual float GetMoveSpeed()
    {
        return m_MoveSpeed;
    }
}
