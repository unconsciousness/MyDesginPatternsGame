using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAIState : IAIState
{
    public override void RemoveTarget(ICharacter Target)
    {
        base.RemoveTarget(Target);
    }

    public override void SetAttackPosition(Vector3 AttackPosition)
    {
        base.SetAttackPosition(AttackPosition);
    }

    public override void Update(List<ICharacter> Targets)
    {
        throw new System.NotImplementedException();
    }
}

	

