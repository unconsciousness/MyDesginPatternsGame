using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAIState
{
    protected ICharachterAI m_CharacterAI = null;//角色AI（状态的拥有者）
    public IAIState() { }

    //设置CharacterAI的对象
    public void SetCharacterAI(ICharachterAI CharachterAI)
    {
        m_CharacterAI = CharachterAI;
    }

    //设置要攻击的目标
    public virtual void SetAttackPosition(Vector3 AttackPosition) { }

    //更新
    public abstract void Update(List<ICharacter> Targets);

    //目标被删除
    public virtual void RemoveTarget(ICharacter Target) { }
}
