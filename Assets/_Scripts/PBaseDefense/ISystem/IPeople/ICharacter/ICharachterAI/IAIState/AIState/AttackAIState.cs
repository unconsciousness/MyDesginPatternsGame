using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAIState : IAIState
{
    private ICharacter m_AttackTarget = null;//攻击的目标


    

   

    

    //更新
    public override void Update(List<ICharacter> Targets)
    {
        //没有目标时，改为Idle
        if (m_AttackTarget == null ||
            m_AttackTarget.IsKilled() ||
            Targets == null ||
            Targets.Count == 0)
        {
            m_CharacterAI.ChangeAIState(new IdleAIState());
            return;
        }

        //有目标但是不在攻击范围里，追击
        if (m_CharacterAI.TargetInAttackRange(m_AttackTarget) == false)
        {
            m_CharacterAI.ChangeAIState(new ChaseAIState(m_AttackTarget));
            return;
        }

        //有目标且在攻击范围里，攻击
        m_CharacterAI.Attack(m_AttackTarget);
    }

    //目标被删除(清理死亡目标的指向？防止NULL指向错误？)
    public override void RemoveTarget(ICharacter Target)
    {
        if (m_AttackTarget.GetGameObject().name == Target.GetGameObject().name)
        {
            m_AttackTarget = null;
        }
    }

}
