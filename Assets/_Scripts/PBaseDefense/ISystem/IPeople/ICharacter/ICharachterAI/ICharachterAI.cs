using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharachterAI  {

    public abstract void Update();

    public abstract void ChangeAIState(IAIState AIState);
}
