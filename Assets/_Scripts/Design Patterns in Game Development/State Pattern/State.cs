﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{
	State m_State = null;

	public void Request(int Value)
	{
		m_State.Handle(Value);
	}

	public void SetState(State theState)
	{
		Debug.Log("Context.SetState:" + theState);
		m_State = theState;
	}
}




public abstract class State  {
	protected Context m_Context = null;
	public State(Context theContext)
	{
		m_Context = theContext;
	}
	public abstract void Handle(int Value);
}


public class ConcreteStateA : State
{
	public ConcreteStateA(Context theContext) : base(theContext)
	{
		//Debug.Log("new ConcreteStateA()");
	}
	public override void Handle(int Value)
	{
		Debug.Log("ConcreteStateA.Handle");
		if ( Value > 10)
			m_Context.SetState(new ConcreteStateB(m_Context));
	}
}

public class ConcreteStateB : State
{
	public ConcreteStateB(Context theContext) : base(theContext) { }
	public override void Handle(int Value)
	{
		Debug.Log("ConcreteStateB.Handle");
		if (Value > 20)
			m_Context.SetState(new ConcreteStateC(m_Context));
	}
}


public class ConcreteStateC : State
{
	public ConcreteStateC(Context theContext) : base(theContext) { }
	public override void Handle(int Value)
	{
		Debug.Log("ConcreteStateC.Handle");
		if (Value > 30)
			m_Context.SetState(new ConcreteStateA(m_Context));
	}
}