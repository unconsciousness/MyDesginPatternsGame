using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAIState : IAIState
{
    //是否设置了攻击目标
    bool m_bSetAttackPosition = false;

    public IdleAIState() { }

    public override void RemoveTarget(ICharacter Target)
    {
        base.RemoveTarget(Target);
    }

    //设置要攻击的目标
    public override void SetAttackPosition(Vector3 AttackPosition)
    {
        m_bSetAttackPosition = true;
    }

    //更新
    public override void Update(List<ICharacter> Targets)
    {
        //没有目标时
        if (Targets == null || Targets.Count == 0)
        {
            //如果有设置了攻击目标
            if (m_bSetAttackPosition)
                m_CharacterAI.ChangeAIState(new MoveAIState());
            return;
        }

        //如果有目标，找出最近的目标
        Vector3 NowPosition = m_CharacterAI.GetPosition();

        ICharacter theNearTarget = null;
        float MinDist = 999;
        foreach (var Target in Targets)
        {
            //已经阵亡的不计算
            if (Target.IsKilled())            
                continue;

            float dist = Vector3.Distance(NowPosition, Target.GetGameObject().transform.position);
            if (dist < MinDist)
            {
                MinDist = dist;
                theNearTarget = Target;
            }
        }

        //没有目标，会不动
        if (theNearTarget == null)
            return;

        //是否在距离内
        if (m_CharacterAI.TargetInAttackRange(theNearTarget))
            m_CharacterAI.ChangeAIState(new AttackAIState(theNearTarget));
        else
            m_CharacterAI.ChangeAIState(new ChaseAIState(theNearTarget));
    }
}
